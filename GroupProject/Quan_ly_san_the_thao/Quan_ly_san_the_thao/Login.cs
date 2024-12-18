using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataRow dr = dbHelper.GetUsernameAndPwd(tb_Username.Text);
            if (dr[1].ToString() == tb_Password.Text)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();

                Thread t = new Thread(() =>
                {
                    SportListForm sportListForm = new SportListForm(tb_Username.Text);
                    Application.Run(sportListForm);
                });
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
            else
            {
                MessageBox.Show("Sai username hoặc password");
            }
        }

        private void llb_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Visible = false;
            register.ShowDialog();
            this.Visible = true;
        }

        private void llb_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ quản trị viên để lấy lại mật khẩu!\nEmail ADMIN: contact.adamnguyen@gmail.com.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
