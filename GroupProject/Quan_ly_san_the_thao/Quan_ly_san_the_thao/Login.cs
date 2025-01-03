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
            if (string.IsNullOrWhiteSpace(tb_Password.Text) || string.IsNullOrWhiteSpace(tb_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow credentials = new DatabaseHelper().GetCredentials(tb_Username.Text);
            if (credentials != null && credentials[1].ToString() == tb_Password.Text)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (tb_Username.Text == "admin") new AdminMenu(tb_Username.Text).Show();
                else new MainMenu(tb_Username.Text).Show();
            }
            else MessageBox.Show("Sai username hoặc password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (new DatabaseHelper().SendPasswordResetRequest(tb_Username.Text))
                MessageBox.Show("Đã gửi yêu cầu reset mật khẩu đến quản trị viên!\nHãy đợi trong 30 phút và sử dụng mật khẩu glorymanunited để đăng nhập và đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Gửi yêu cầu thất bại. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = false;
            btn_Hide.BringToFront();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
            btn_Show.BringToFront();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
