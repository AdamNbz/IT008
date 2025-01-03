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
    public partial class SportSelection : Form
    {
        string username;
        DataRow userDetails;
        public SportSelection(string currentUser)
        {
            InitializeComponent();
            this.username = currentUser;
            userDetails = new DatabaseHelper().GetUserDetails(username);
        }

        private void btn_Football_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TimeSelection(userDetails, "Bóng đá").ShowDialog();
            this.Show();
        }

        private void btn_Volleyball_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TimeSelection(userDetails, "Bóng chuyền").ShowDialog();
            this.Show();
        }

        private void btn_Basketball_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TimeSelection(userDetails, "Bóng rổ").ShowDialog();
            this.Show();
        }

        private void btn_Badminton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TimeSelection(userDetails, "Cầu lông").ShowDialog();
            this.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
