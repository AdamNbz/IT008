using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public partial class Deposit : Form
    {
        string currentUser;
        public Deposit(string username, string balance)
        {
            InitializeComponent();
            this.currentUser = username;
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {
            if (sender == btn_50k) tb_EnterMoney.Text = "50000";
            else if (sender == btn_100k) tb_EnterMoney.Text = "100000";
            else if (sender == btn_200k) tb_EnterMoney.Text = "200000";
            else if (sender == btn_500k) tb_EnterMoney.Text = "500000";
            else if (sender == btn_1M) tb_EnterMoney.Text = "1000000";
            else if (sender == btn_2M) tb_EnterMoney.Text = "2000000";

            tb_EnterMoney.ForeColor = Color.Black;
        }

        private void tb_EnterMoney_Enter(object sender, EventArgs e)
        {
            if (tb_EnterMoney.Text == "0")
            {
                tb_EnterMoney.Text = "";
                tb_EnterMoney.ForeColor = Color.Black;
            }
        }

        private void tb_EnterMoney_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EnterMoney.Text))
            {
                tb_EnterMoney.Text = "0";
                tb_EnterMoney.ForeColor = Color.Gray;
            }
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EnterMoney.Text)) 
                MessageBox.Show("Số tiền cần nạp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            long currentDonate = long.TryParse(tb_EnterMoney.Text, out long donate) ? donate : 0;
            if (currentDonate / 1000 != 0) 
                MessageBox.Show("Số tiền cần nạp phải chia hết cho 1000!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DialogResult answer = MessageBox.Show("Bạn chắc chắn đã chuyển khoản rồi chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                MessageBox.Show("Đã gửi yêu cầu kiểm tra nạp tiền đến quản trị viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new DatabaseHelper().SendDepositRequest(currentUser, currentDonate);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
