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
    public partial class AddStudent : Form
    {
        public Student newStudent;
        public AddStudent()
        {
            InitializeComponent();
        }
        bool isValid()
        {
            if (idBox.Text == "" || nameBox.Text == "" || majorBox.Text == "" || scoreBox.Text == "" || trainingPointBox.Text == "") return false;
            foreach (char c in idBox.Text)
            {
                if (c - '0' < 0 || c - '0' > 9)
                {
                    idBox.Text = "";
                    return false;
                }
            }
            foreach (char c in nameBox.Text)
            {
                if (c >= '0' && c <= '9')
                {
                    nameBox.Text = "";
                    return false;
                }
            }
            double tmp;
            if (!double.TryParse(scoreBox.Text, out tmp))
            {
                scoreBox.Text = "";
                return false;
            }
            if (tmp < 0 || tmp > 10)
            {
                scoreBox.Text = "";
                return false;
            }
            int tmp2;
            if (!int.TryParse(trainingPointBox.Text, out tmp2))
            {
                trainingPointBox.Text = "";
                return false;
            }
            if (tmp2 < 0 || tmp2 > 100)
            {
                trainingPointBox.Text = "";
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                newStudent = new Student(idBox.Text, nameBox.Text, majorBox.Text, double.Parse(scoreBox.Text), int.Parse(trainingPointBox.Text));
                this.Close();
            }
            else MessageBox.Show("Thông tin bạn vừa nhập sai hoặc bạn chưa nhập thông tin!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" && nameBox.Text == "" && majorBox.Text == "") this.Close();
            else
            {
                DialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát?", "XÁC NHẬN", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes) this.Close();
            }
        }
    }
}
