﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Quan_ly_san_the_thao
{
    public partial class MainMenu : Form
    {
        string username;
        DataRow userDetails;
        private Form currentSubForm;
        public MainMenu(string loggedUser)
        {
            InitializeComponent();
            InitializeMenu();
            this.username = loggedUser;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            userDetails = new DatabaseHelper().GetUserDetails(username);
            string[] parts = userDetails["TENKH"].ToString().Split(' ');
            string name = parts[parts.Length - 1];
            lb_Hello.Text = "Xin chào, " + name.ToString(new CultureInfo("vi-VN")) + "!";
            lb_Balance.Text = "Số dư: " + Convert.ToInt64(userDetails["SODU"]).ToString("N0", new CultureInfo("vi-VN")) + " VND";
        }

        private void OpenSubForm(Form subForm)
        {
            if (currentSubForm != null) currentSubForm.Close();
            currentSubForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            pn_SubmenuForm.Controls.Add(subForm);
            pn_SubmenuForm.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
        }

        private void AdjustFontSize(Label label)
        {
            Font originalFont = label.Font;
            float fontSize = originalFont.Size;

            using (Graphics g = label.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(label.Text, originalFont);
                while ((textSize.Width > label.Width || textSize.Height > label.Height) && fontSize > 0.5f)
                {
                    fontSize -= 0.5f;
                    using (Font testFont = new Font(originalFont.FontFamily, fontSize, originalFont.Style))
                    {
                        textSize = g.MeasureString(label.Text, testFont);
                    }
                }

                label.Font = new Font(originalFont.FontFamily, fontSize, originalFont.Style);
            }
        }

        private void UserLoggedIn_TextChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            AdjustFontSize(lb);
        }

        private void InitializeMenu()
        {
            pn_settingSubmenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pn_settingSubmenu.Visible == true) pn_settingSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel sub)
        {
            if (sub.Visible == false)
            {
                HideSubMenu();
                sub.Visible = true;
            } 
            else sub.Visible = false;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pn_settingSubmenu);
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            OpenSubForm(new Profile(userDetails));
            HideSubMenu();
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword(username).ShowDialog();
            this.Show();
            HideSubMenu();
        }

        private void btn_Donate_Click(object sender, EventArgs e)
        {
            OpenSubForm(new Deposit(username, userDetails["SODU"].ToString()));
            HideSubMenu();
        }

        private void btn_SelectField_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SportSelection(username));
            HideSubMenu();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}