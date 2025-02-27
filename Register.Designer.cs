﻿
namespace BookShopManagementSystem
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lbl_status = new System.Windows.Forms.Label();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.cb_show_pass = new System.Windows.Forms.CheckBox();
            this.lbl_pass_again = new System.Windows.Forms.Label();
            this.pnl_surname = new System.Windows.Forms.Panel();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pnl_pass_confirm = new System.Windows.Forms.Panel();
            this.tb_pass_confirm = new System.Windows.Forms.TextBox();
            this.pnl_pass = new System.Windows.Forms.Panel();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.cb_is_seller = new System.Windows.Forms.CheckBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.pnl_form.SuspendLayout();
            this.pnl_surname.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_pass_confirm.SuspendLayout();
            this.pnl_pass.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(223, 443);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 28);
            this.lbl_status.TabIndex = 72;
            // 
            // pnl_form
            // 
            this.pnl_form.AutoScroll = true;
            this.pnl_form.Controls.Add(this.lbl_status);
            this.pnl_form.Controls.Add(this.cb_show_pass);
            this.pnl_form.Controls.Add(this.lbl_pass_again);
            this.pnl_form.Controls.Add(this.pnl_surname);
            this.pnl_form.Controls.Add(this.pnl_name);
            this.pnl_form.Controls.Add(this.pnl_pass_confirm);
            this.pnl_form.Controls.Add(this.pnl_pass);
            this.pnl_form.Controls.Add(this.panel2);
            this.pnl_form.Controls.Add(this.pnl_email);
            this.pnl_form.Controls.Add(this.btn_register);
            this.pnl_form.Controls.Add(this.cb_is_seller);
            this.pnl_form.Controls.Add(this.lbl_name);
            this.pnl_form.Controls.Add(this.lbl_email);
            this.pnl_form.Controls.Add(this.lbl_pass);
            this.pnl_form.Controls.Add(this.lbl_adress);
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(0, 0);
            this.pnl_form.Margin = new System.Windows.Forms.Padding(15);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(1043, 639);
            this.pnl_form.TabIndex = 73;
            // 
            // cb_show_pass
            // 
            this.cb_show_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_show_pass.AutoSize = true;
            this.cb_show_pass.Location = new System.Drawing.Point(223, 404);
            this.cb_show_pass.Name = "cb_show_pass";
            this.cb_show_pass.Size = new System.Drawing.Size(165, 29);
            this.cb_show_pass.TabIndex = 6;
            this.cb_show_pass.Text = "Show password";
            this.cb_show_pass.UseVisualStyleBackColor = true;
            this.cb_show_pass.CheckedChanged += new System.EventHandler(this.cb_show_pass_CheckedChanged);
            // 
            // lbl_pass_again
            // 
            this.lbl_pass_again.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pass_again.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass_again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_pass_again.Location = new System.Drawing.Point(218, 319);
            this.lbl_pass_again.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass_again.Name = "lbl_pass_again";
            this.lbl_pass_again.Size = new System.Drawing.Size(211, 25);
            this.lbl_pass_again.TabIndex = 84;
            this.lbl_pass_again.Text = "Password Confirmation:";
            // 
            // pnl_surname
            // 
            this.pnl_surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_surname.Controls.Add(this.tb_surname);
            this.pnl_surname.Location = new System.Drawing.Point(521, 37);
            this.pnl_surname.Name = "pnl_surname";
            this.pnl_surname.Size = new System.Drawing.Size(305, 45);
            this.pnl_surname.TabIndex = 10;
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_surname.Location = new System.Drawing.Point(10, 10);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(286, 27);
            this.tb_surname.TabIndex = 1;
            // 
            // pnl_name
            // 
            this.pnl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_name.Controls.Add(this.tb_name);
            this.pnl_name.Location = new System.Drawing.Point(218, 37);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(297, 45);
            this.pnl_name.TabIndex = 9;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_name.Location = new System.Drawing.Point(6, 10);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(286, 27);
            this.tb_name.TabIndex = 0;
            // 
            // pnl_pass_confirm
            // 
            this.pnl_pass_confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_pass_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_pass_confirm.Controls.Add(this.tb_pass_confirm);
            this.pnl_pass_confirm.Location = new System.Drawing.Point(218, 349);
            this.pnl_pass_confirm.Name = "pnl_pass_confirm";
            this.pnl_pass_confirm.Size = new System.Drawing.Size(608, 45);
            this.pnl_pass_confirm.TabIndex = 14;
            // 
            // tb_pass_confirm
            // 
            this.tb_pass_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pass_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_pass_confirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_pass_confirm.Location = new System.Drawing.Point(5, 10);
            this.tb_pass_confirm.Name = "tb_pass_confirm";
            this.tb_pass_confirm.Size = new System.Drawing.Size(596, 27);
            this.tb_pass_confirm.TabIndex = 5;
            // 
            // pnl_pass
            // 
            this.pnl_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_pass.Controls.Add(this.tb_pass);
            this.pnl_pass.Location = new System.Drawing.Point(218, 270);
            this.pnl_pass.Name = "pnl_pass";
            this.pnl_pass.Size = new System.Drawing.Size(608, 45);
            this.pnl_pass.TabIndex = 13;
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_pass.Location = new System.Drawing.Point(5, 10);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(596, 27);
            this.tb_pass.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.tb_adress);
            this.panel2.Location = new System.Drawing.Point(218, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 45);
            this.panel2.TabIndex = 12;
            // 
            // tb_adress
            // 
            this.tb_adress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_adress.Location = new System.Drawing.Point(6, 13);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(596, 27);
            this.tb_adress.TabIndex = 3;
            // 
            // pnl_email
            // 
            this.pnl_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_email.Controls.Add(this.tb_email);
            this.pnl_email.Location = new System.Drawing.Point(218, 112);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(608, 45);
            this.pnl_email.TabIndex = 11;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.tb_email.Location = new System.Drawing.Point(5, 11);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(596, 27);
            this.tb_email.TabIndex = 2;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(410, 489);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(200, 50);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cb_is_seller
            // 
            this.cb_is_seller.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_is_seller.AutoSize = true;
            this.cb_is_seller.Location = new System.Drawing.Point(504, 404);
            this.cb_is_seller.Name = "cb_is_seller";
            this.cb_is_seller.Size = new System.Drawing.Size(139, 29);
            this.cb_is_seller.TabIndex = 7;
            this.cb_is_seller.Text = "I am a seller.";
            this.cb_is_seller.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_name.Location = new System.Drawing.Point(218, 9);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 25);
            this.lbl_name.TabIndex = 72;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_email.Location = new System.Drawing.Point(218, 84);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 25);
            this.lbl_email.TabIndex = 73;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_pass.Location = new System.Drawing.Point(218, 239);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(95, 25);
            this.lbl_pass.TabIndex = 75;
            this.lbl_pass.Text = "Password:";
            // 
            // lbl_adress
            // 
            this.lbl_adress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_adress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.lbl_adress.Location = new System.Drawing.Point(218, 162);
            this.lbl_adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(72, 25);
            this.lbl_adress.TabIndex = 74;
            this.lbl_adress.Text = "Address:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 639);
            this.Controls.Add(this.pnl_form);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.pnl_surname.ResumeLayout(false);
            this.pnl_surname.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_pass_confirm.ResumeLayout(false);
            this.pnl_pass_confirm.PerformLayout();
            this.pnl_pass.ResumeLayout(false);
            this.pnl_pass.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.CheckBox cb_show_pass;
        private System.Windows.Forms.Label lbl_pass_again;
        private System.Windows.Forms.Panel pnl_surname;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Panel pnl_pass_confirm;
        private System.Windows.Forms.TextBox tb_pass_confirm;
        private System.Windows.Forms.Panel pnl_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox cb_is_seller;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_adress;
    }
}