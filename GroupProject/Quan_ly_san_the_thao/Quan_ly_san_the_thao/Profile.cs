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

namespace Quan_ly_san_the_thao
{
    public partial class Profile : Form
    {
        DataRow userData;
        private string sqlConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_DATABASE_PROJECT;Integrated Security=True";
        public Profile(DataRow userData)
        {
            InitializeComponent();
            this.userData = userData;
            ShowProfile();
        }

        void ShowProfile()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            tb_Fullname.Text = userData["TENKH"].ToString();
            tb_Username.Text = userData["USERNAME"].ToString();
            tb_PhoneNumber.Text = userData["SDT"].ToString();
            tb_Gender.Text = (bool)userData["GTINH"] ? "Nam" : "Nữ";
            tb_Email.Text = userData["EMAIL"].ToString();

            string query = "SELECT COUNT(*) FROM HOADON HD JOIN KHACHHANG KH ON HD.USERNAME = KH.USERNAME WHERE HD.USERNAME = @username";
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", tb_Username.Text);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                tb_Amount.Text = count.ToString();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
