﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class Login : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly Regex _emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private Home home;
        private ResourceManager rm;
        public Login(Home home, ResourceManager rm)
        {
            InitializeComponent();
            this.home = home;
            this.rm = rm;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_email.Text = $"{rm.GetString("email")}:";
            cb_show_pass.Text = rm.GetString("showpass");
            lbl_pass.Text = $"{rm.GetString("password")}:";
            cb_save_log.Text = rm.GetString("keep");
            btn_login.Text = rm.GetString("login");
            tb_password.PasswordChar = '•';
            pnl_form.AutoScroll = true;
            pnl_form.AutoScrollMargin = new Size(10, 10);
            cb_save_log.Checked = true;
        }

        private void cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_show_pass.Checked ? '\0' : '•';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            if (!(String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)))
            {
                if (_emailRegex.IsMatch(email))
                {
                    LoginModel lm = new LoginModel()
                    {
                        Email = email,
                        Password = password,
                        KeepMeLoggedIn = cb_save_log.Checked,
                    };
                    btn_login.IsAccessible = false;
                    bool isLoggedIn = _userController.LoginUser(lm);
                    if (isLoggedIn)
                    {
                        home.Hide();
                        tb_email.Text = "";
                        tb_password.Text = "";
                        ShopCenter sc = new ShopCenter(home);
                        sc.Show();
                    }
                    else
                    {
                        sb.Append("Email or password is wrong.");
                        btn_login.IsAccessible = true;
                    }
                }
                else sb.Append("Email is not valid.");
            }
            else sb.Append("Fill all fields.");
            lbl_status.ForeColor = Color.Maroon;
            lbl_status.Text = sb.ToString();
        }
    }
}
