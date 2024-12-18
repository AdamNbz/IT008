using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_san_the_thao
{
    public partial class SportListForm : Form
    {
        bool isLoggedIn;
        string username;
        DataRow userDetail;
        private string selectedSport;
        public SportListForm(string user)
        {
            InitializeComponent();
            isLoggedIn = true;
            this.username = user;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            userDetail = new DatabaseHelper().GetUserDetails(username);
            string[] parts = userDetail["TENKH"].ToString().Split(' ');
            string name = parts[parts.Length - 1];
            lb_Greeting.Text = "CHÀO MỪNG " + name.ToUpper(new System.Globalization.CultureInfo("vi-VN")) 
                                            + "\r\nĐẾN VỚI KHU PHỨC HỢP SE SPORT";
        }

        private void AdjustFontSize(Label label)
        {
            Graphics g = label.CreateGraphics();
            Font currentFont = label.Font;
            SizeF textSize = g.MeasureString(label.Text, currentFont);

            while (textSize.Width > label.Width || textSize.Height > label.Height)
            {
                currentFont = new Font(currentFont.FontFamily, currentFont.Size - 0.5f, currentFont.Style);
                textSize = g.MeasureString(label.Text, currentFont);
            }

            label.Font = currentFont;
            g.Dispose();
        }

        private void SportListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this != Application.OpenForms[0])
            {
                Application.Exit();
            }
        }

        private void lb_Greeting_TextChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            AdjustFontSize(lb);
        }

        private void lb_Greeting_Resize(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            AdjustFontSize(lb);
        }

        private void tsmi_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            isLoggedIn = false;
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedSport = "Cầu lông";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng rổ";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng chuyền";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng đá";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void tsmi_ChangePW_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangePassword changepw = new ChangePassword(username);
            changepw.ShowDialog();
            this.Visible = true;
        }
    }
}
