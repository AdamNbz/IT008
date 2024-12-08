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
    public partial class EditStudent : Form
    {
        public string UpdatedName { get; private set; }
        public string UpdatedID { get; private set; }
        public string UpdatedDepartment { get; private set; }
        public double UpdatedScore { get; private set; }
        public int UpdatedTP { get; private set; }
        public EditStudent(string name, string id, string department, double score, int tp)
        {
            InitializeComponent();
            UpdatedName = name;
            UpdatedID = id;
            UpdatedDepartment = department;
            UpdatedScore = score;
            UpdatedTP = tp;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            idBox.Text = UpdatedID;
            nameBox.Text = UpdatedName;
            majorBox.Text = UpdatedDepartment;
            scoreBox.Text = UpdatedScore.ToString();
            trainingPointBox.Text = UpdatedTP.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdatedName = nameBox.Text.Trim();
            UpdatedID = idBox.Text.Trim();
            UpdatedScore = Double.Parse(scoreBox.Text.Trim());
            UpdatedDepartment = majorBox.Text.Trim();
            UpdatedTP = int.Parse(trainingPointBox.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
