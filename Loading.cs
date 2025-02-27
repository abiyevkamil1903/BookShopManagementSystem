﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class Loading : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly DataContext _context = new DataContext();
        private List<Book> books;
        private User user;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            if (bw_load_db.IsBusy) bw_load_db.CancelAsync();
            bw_load_db.RunWorkerAsync();
            tmr_loading.Start();
            user = _userController.GetUserDataFromLocal();
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            if (books == null)
            {
                if (pb_loading.Value == 99) pb_loading.Value = 0;

                pb_loading.Value += 1;
            }
            else
            {
                bw_load_db.Dispose();
                tmr_loading.Stop();
                this.Hide();
                Home home = new Home();
                if (user == null)
                    home.Show();
                else
                {
                    ShopCenter sc = new ShopCenter(home);
                    sc.Show();
                }
            }
        }

        private void bw_load_db_DoWork(object sender, DoWorkEventArgs e)
        {
            books = _context.Books.ToList();
        }
    }
}
