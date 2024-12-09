using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalProject
{
    public partial class MainPage : Form
    {
        DataTable dt = new DataTable();
        static int cnt = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            if (addStudent.newStudent != null)
                studentList.Rows.Add(cnt++, addStudent.newStudent.id, addStudent.newStudent.name, addStudent.newStudent.department, addStudent.newStudent.score.ToString(), addStudent.newStudent.tp.ToString());
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < studentList.Rows.Count; i++)
            {
                if (studentList.Rows[i].Cells[2].Value != null && studentList.Rows[i].Cells[2].Value.ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    studentList.Rows[i].Visible = true;
                else studentList.Rows[i].Visible = false;
            }
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            addButton_Click((object)sender, e);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormClosed_Click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (studentList.CurrentRow != null)
            {
                DialogResult = MessageBox.Show("Bạn có chắc chắn là xoá sinh viên này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                    studentList.Rows.RemoveAt(studentList.CurrentRow.Index);
            }
            else
                MessageBox.Show("Hãy chọn 1 sinh viên để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (studentList.CurrentRow != null)
            {
                string curName = studentList.CurrentRow.Cells[2].Value.ToString();
                string curID = studentList.CurrentRow.Cells[1].Value.ToString();
                string curDepartment = studentList.CurrentRow.Cells[3].Value.ToString();
                double curScore = Double.Parse(studentList.CurrentRow.Cells[4].Value.ToString());
                int curTP = int.Parse(studentList.CurrentRow.Cells[5].Value.ToString());
                if (curName != null && curID != null && curDepartment != null && curScore != 0 && curTP != 0)
                {
                    EditStudent edit = new EditStudent(curName, curID, curDepartment, curScore, curTP);
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        studentList.CurrentRow.Cells[2].Value = edit.UpdatedName;
                        studentList.CurrentRow.Cells[1].Value = edit.UpdatedID;
                        studentList.CurrentRow.Cells[3].Value = edit.UpdatedDepartment;
                        studentList.CurrentRow.Cells[4].Value = edit.UpdatedScore;
                        studentList.CurrentRow.Cells[5].Value = edit.UpdatedTP;
                        studentList.Refresh();
                    }
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin sinh viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Hãy chọn 1 sinh viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditButton_Click(sender, e);
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog fo = new OpenFileDialog { Filter = "Excel Files|*.xlsx", Title = "Mở File Excel" };
            if (fo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(fo.FileName)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.First();
                        int rowCount = worksheet.Dimension.Rows;

                        for (int row = 2; row <= rowCount; row++)
                        {
                            string id = worksheet.Cells[row, 1].Value?.ToString();
                            string name = worksheet.Cells[row, 2].Value?.ToString();
                            string department = worksheet.Cells[row, 3].Value?.ToString();
                            double score = double.Parse(worksheet.Cells[row, 4].Value?.ToString() ?? "0");
                            int tp = int.Parse(worksheet.Cells[row, 5].Value?.ToString() ?? "0");

                            studentList.Rows.Add(cnt++, id, name, department, score, tp);
                        }

                        MessageBox.Show("Import dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("SinhVien");

                            // Add headers
                            for (int i = 0; i < studentList.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = studentList.Columns[i].HeaderText;
                            }

                            // Add data
                            for (int i = 0; i < studentList.Rows.Count; i++)
                            {
                                for (int j = 0; j < studentList.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = studentList.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                            package.SaveAs(new FileInfo(saveFileDialog.FileName));

                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhậpFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportButton_Click(sender, e);
        }

        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportButton_Click(sender, e);
        }
    }
}
