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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_EnterMoney_Enter(object sender, EventArgs e)
        {
            if (tb_EnterMoney.Text == "0đ")
            {
                tb_EnterMoney.Text = "";
                tb_EnterMoney.ForeColor = Color.Black;
            }
        }

        private void tb_EnterMoney_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EnterMoney.Text))
            {
                tb_EnterMoney.Text = "0đ";
                tb_EnterMoney.ForeColor = Color.LightGray;
            }
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {

        }
    }
}
