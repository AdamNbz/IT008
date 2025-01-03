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
    public partial class Coupon : Form
    {
        DataTable couponList;
        public Coupon()
        {
            InitializeComponent();
            LoadCouponData();
            UpdateButtonState();
        }

        private void LoadCouponData()
        {
            dgv_CouponList.AutoGenerateColumns = false;
            couponList = new DatabaseHelper().GetCouponList();
            new DatabaseHelper().UpdateCouponStatus();
            dgv_CouponList.DataSource = couponList;
        }

        private void UpdateButtonState()
        {
            if (dgv_CouponList.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dgv_CouponList.SelectedRows[0].DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    btn_Delete.Enabled = true;
                }
            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_CouponCode.Text) 
                || string.IsNullOrWhiteSpace(tb_Value.Text) 
                || string.IsNullOrWhiteSpace(tb_Time.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string couponCode = tb_CouponCode.Text;
            decimal discount = Convert.ToDecimal(tb_Value.Text);
            int daysValid = Convert.ToInt32(tb_Time.Text);
            if (discount > 0 && daysValid > 0)
            {
                DateTime expired = DateTime.Now.AddDays(daysValid); 
                new DatabaseHelper().AddCoupon(couponCode, discount, expired);
                MessageBox.Show("Thêm mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCouponData();
            }
            else
            {
                MessageBox.Show("Số tiền giảm giá hoặc thời gian hiệu lực không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_CouponList.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRow != null)
            {
                string couponCode = selectedRow["MaGiamGia"].ToString();
                new DatabaseHelper().DeleteCoupon(couponCode);
                MessageBox.Show("Xóa mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCouponData();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_SearchCoupon.Text))
            {
                LoadCouponData();
            }
            else
            {
                string searchCoupon = tb_SearchCoupon.Text;
                DataView dv = couponList.DefaultView;
                dv.RowFilter = string.Format("MaGiamGia LIKE '%{0}%'", searchCoupon);
                dgv_CouponList.DataSource = dv;
            }
        }
    }
}
