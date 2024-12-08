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
    }
}
