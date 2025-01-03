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
    public partial class Customer : Form
    {
        DataTable customerList;
        public Customer()
        {
            InitializeComponent();
            LoadCustomerData();
            UpdateButtonState();
        }

        void LoadCustomerData()
        {
            dgv_CustomerList.AutoGenerateColumns = false;
            customerList = new DatabaseHelper().GetCustomerList();
            dgv_CustomerList.DataSource = customerList;
        }

        private void UpdateButtonState()
        {
            if (dgv_CustomerList.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dgv_CustomerList.SelectedRows[0].DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    int trangThai = Convert.ToInt32(selectedRow["TrangThaiRequest"]);
                    btn_Deposit.Enabled = trangThai == 0;
                    btn_ChangePW.Enabled = trangThai == 1;
                }
            }
            else
            {
                btn_Deposit.Enabled = false;
                btn_ChangePW.Enabled = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_CustomerList_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_CustomerList.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRow != null)
            {
                string username = selectedRow["Username"].ToString();
                new AdminDeposit(username).ShowDialog();
            }
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_CustomerList.SelectedRows[0].DataBoundItem as DataRowView;
            new DatabaseHelper().UpdatePassword(selectedRow["Username"].ToString(), "glorymanunited");
            MessageBox.Show("Đặt lại mật khẩu thành công cho khách hàng" + selectedRow["TenKH"].ToString() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Search.Text))
                LoadCustomerData();
            else
            {
                string searchName = tb_Search.Text;
                DataView dataView = customerList.DefaultView;
                dataView.RowFilter = $"TenKH LIKE '%{searchName}%'";
                dgv_CustomerList.DataSource = dataView;
            }
        }
    }
}
