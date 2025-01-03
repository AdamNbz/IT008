using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Quan_ly_san_the_thao
{
    public partial class BillList : Form
    {
        DataTable billList;
        public BillList()
        {
            InitializeComponent();
            LoadBillData();
        }

        void UpdatePrintingStatus()
        {
            DataRowView selectedRow = dgv_BillList.SelectedRows.Count > 0 ? dgv_BillList.SelectedRows[0].DataBoundItem as DataRowView : null;
            if (selectedRow != null)
            {
                btn_PrintBill.Enabled = selectedRow["TRANGTHAIHD"].ToString() == "1";
                btn_UpdateStats.Enabled = true;
            }
            else
            {
                btn_PrintBill.Enabled = false;
                btn_UpdateStats.Enabled = false;
            }
        }

        void LoadBillData()
        {
            dgv_BillList.AutoGenerateColumns = false;
            billList = new DatabaseHelper().GetBillList();
            dgv_BillList.DataSource = billList;
            UpdatePrintingStatus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_BillList.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRow != null)
            {
                string username = selectedRow["Username"].ToString();
                new AdminDeposit(username).ShowDialog();
            }
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_BillList.SelectedRows[0].DataBoundItem as DataRowView;
            new DatabaseHelper().UpdatePassword(selectedRow["Username"].ToString(), "glorymanunited");
            MessageBox.Show("Đặt lại mật khẩu thành công cho khách hàng" + selectedRow["TenKH"].ToString() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Search.Text))
                LoadBillData();
            else
            {
                string searchName = tb_Search.Text;
                DataView dataView = billList.DefaultView;
                dataView.RowFilter = $"TenKH LIKE '%{searchName}%'";
                dgv_BillList.DataSource = dataView;
            }
        }

        private void btn_PrintBill_Click(object sender, EventArgs e)
        {
            if (dgv_BillList.SelectedRows.Count > 0)
            {
                DataRowView selectedRow = dgv_BillList.SelectedRows[0].DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet workSheet = excelApp.ActiveSheet;

                    workSheet.Cells[1, "A"] = "Mã Hóa Đơn";
                    workSheet.Cells[1, "B"] = "Username";
                    workSheet.Cells[1, "C"] = "Ngày Hiệu Lực";
                    workSheet.Cells[1, "D"] = "Khung Giờ";
                    workSheet.Cells[1, "E"] = "Sân Đặt";
                    workSheet.Cells[1, "F"] = "Trị Giá";
                    workSheet.Cells[1, "G"] = "Trạng Thái";

                    workSheet.Cells[2, "A"] = selectedRow["MAHD"];
                    workSheet.Cells[2, "B"] = selectedRow["USERNAME"];
                    workSheet.Cells[2, "C"] = selectedRow["NGHDHLUC"];
                    workSheet.Cells[2, "D"] = selectedRow["KHUNGGIO"];
                    workSheet.Cells[2, "E"] = selectedRow["SANDAT"];
                    workSheet.Cells[2, "F"] = selectedRow["TRIGIA"];
                    workSheet.Cells[2, "G"] = selectedRow["TRANGTHAIHD"];

                    excelApp.Visible = true;

                    UpdatePrintingStatus();
                }
            }
        }

        private void btn_UpdateStats_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dgv_BillList.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRow != null) {
                string billId = selectedRow["MAHD"].ToString();
                string newStatus = selectedRow["TRANGTHAIHD"].ToString() == "0" ? "1" : "0";
                new DatabaseHelper().UpdateBillStatus(billId, newStatus);
                MessageBox.Show("Cập nhật trạng thái hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBillData();
            }
        }

        private void dgv_BillList_SelectionChanged(object sender, EventArgs e)
        {
            UpdatePrintingStatus(); 
        }
    }
}
