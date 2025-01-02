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
    public partial class PriceAdjustment : Form
    {
        public PriceAdjustment()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Price_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "0đ")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0đ";
                textBox.ForeColor = Color.LightGray;
            }
        }
    }
}
