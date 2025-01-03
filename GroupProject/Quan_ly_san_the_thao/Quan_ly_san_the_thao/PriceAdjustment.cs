using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Quan_ly_san_the_thao
{
    public partial class PriceAdjustment : Form
    {
        public PriceAdjustment()
        {
            InitializeComponent();
        }

        private void Price_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "0")
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
                textBox.Text = "0";
                textBox.ForeColor = Color.LightGray;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_FieldType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cb_FieldType.SelectedItem.ToString();
            List<decimal> price;
            if (selectedType == "Sân 1")
            {
                price = new DatabaseHelper().GetFieldPrice("SANTT01");
                tb_Morning.Text = $"{price[0]:0}";
                tb_Afternoon.Text = $"{price[1]:0}";
                tb_Evening.Text = $"{price[2]:0}";
            }
            else if (selectedType == "Sân 2")
            {
                price = new DatabaseHelper().GetFieldPrice("SANTT02");
                tb_Morning.Text = $"{price[0]:0}";
                tb_Afternoon.Text = $"{price[1]:0}";
                tb_Evening.Text = $"{price[2]:0}";
            }
            else
            {
                price = new DatabaseHelper().GetFieldPrice("SANTT03");
                tb_Morning.Text = $"{price[0]:0}";
                tb_Afternoon.Text = $"{price[1]:0}";
                tb_Evening.Text = $"{price[2]:0}";
            }
            tb_Morning.ForeColor = Color.Black;
            tb_Evening.ForeColor = Color.Black;
            tb_Afternoon.ForeColor = Color.Black;
        }

        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            if (cb_FieldType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sân cần thay đổi giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_Morning.Text) || string.IsNullOrWhiteSpace(tb_Afternoon.Text) || string.IsNullOrWhiteSpace(tb_Evening.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá cho các khung giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_FieldType.SelectedIndex == 0)
                new DatabaseHelper().UpdateFieldPrice("SANTT01", decimal.Parse(tb_Morning.Text), decimal.Parse(tb_Afternoon.Text), decimal.Parse(tb_Evening.Text));
            else if (cb_FieldType.SelectedIndex == 1)
                new DatabaseHelper().UpdateFieldPrice("SANTT02", decimal.Parse(tb_Morning.Text), decimal.Parse(tb_Afternoon.Text), decimal.Parse(tb_Evening.Text));
            else if (cb_FieldType.SelectedIndex == 2)
                new DatabaseHelper().UpdateFieldPrice("SANTT03", decimal.Parse(tb_Morning.Text), decimal.Parse(tb_Afternoon.Text), decimal.Parse(tb_Evening.Text));
            MessageBox.Show("Thay đổi giá sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}