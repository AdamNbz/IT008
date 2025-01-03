using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public partial class ChangePassword : Form
    {
        private string username;
        DataRow userData;
        public ChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
            this.userData = new DatabaseHelper().GetCredentials(username);
        }

        private void btn_ChangePw_Click(object sender, EventArgs e)
        {
            if (tb_CurentPw.Text == "" || tb_NewPw.Text == "" || tb_NewPwConfirm.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tb_CurentPw.Text != userData["PASSWRD"].ToString())
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_NewPw.Text != tb_NewPwConfirm.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new DatabaseHelper().UpdatePassword(username, tb_NewPw.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
