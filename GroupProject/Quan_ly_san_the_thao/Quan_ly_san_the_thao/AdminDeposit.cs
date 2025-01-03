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
    public partial class AdminDeposit : Form
    {
        string currentUser;
        public AdminDeposit(string user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Amount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền cần nạp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal amount = Convert.ToDecimal(tb_Amount.Text);
            if (amount > 0)
            {
                new DatabaseHelper().UpdateCustomerBalance(currentUser, amount);
                MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Số tiền nạp không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
