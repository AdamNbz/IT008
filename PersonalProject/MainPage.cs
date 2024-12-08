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
                studentList.Rows.Add(cnt++, addStudent.newStudent.id, addStudent.newStudent.name, addStudent.newStudent.department, addStudent.newStudent.score.ToString());
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

        private void addLabel_Click(object sender, EventArgs e)
        {
            addButton_Click((object)sender, e);
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
    }
}
