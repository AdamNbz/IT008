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
    public partial class Payment : Form
    {
        private DataRow userData;
        private string mahd;
        private string connection = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_DATABASE_PROJECT;Integrated Security=True";

        public Payment(DataRow user)
        {
            InitializeComponent();
            this.userData = user;
            DisplayInformation();
        }

        private void DisplayInformation()
        {
            lb_Name.Text = userData["TENKH"].ToString();
            lb_Phone.Text = userData["SDT"].ToString();

            string query = "SELECT MAHD, NGTTOAN, TRIGIA FROM HOADON WHERE USERNAME = @username";
            string query2 = "SELECT STT.MONTHETHAO, C.KHUNGGIO FROM SANTHETHAO STT JOIN CTHD C ON STT.MASANTT = C.MASANTT JOIN HOADON HD ON C.MAHD = HD.MAHD WHERE HD.USERNAME = @username";
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", userData["USERNAME"].ToString());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lb_ID.Text = reader["MAHD"].ToString();
                            mahd = lb_ID.Text;
                            decimal trigia = reader.GetDecimal(reader.GetOrdinal("TRIGIA"));
                            string formattedTrigia = $"{trigia:0}VND";
                            lb_Total.Text = formattedTrigia;
                            DateTime reserveDate = reader.GetDateTime(reader.GetOrdinal("NGTTOAN"));
                            lb_ReserveDate.Text = reserveDate.ToShortDateString();
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(query2, connect))
                {
                    cmd.Parameters.AddWithValue("@username", userData["USERNAME"].ToString());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string sport = reader["MONTHETHAO"].ToString();
                            lb_Subject.Text = (sport == "BONGDA") ? "Bóng đá" :
                                              (sport == "BONGCHUYEN") ? "Bóng chuyền" :
                                              (sport == "BONGRO") ? "Bóng rổ" :
                                                                        "Cầu lông";
                            lb_ReserveDate.Text += " " + reader["KHUNGGIO"].ToString() + "g";
                        }
                    }
                }
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xác nhận thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hãy đến thanh toán trực tiếp tại sân và trình ra mã hóa đơn:\n{mahd}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xác nhận hủy đơn không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string deleteCTHDQuery = "DELETE FROM CTHD WHERE MAHD = @MAHD";
                string deleteHoaDonQuery = "DELETE FROM HOADON WHERE MAHD = @MAHD";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(deleteCTHDQuery, connect))
                    {
                        command.Parameters.AddWithValue("@MAHD", mahd);
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(deleteHoaDonQuery, connect))
                    {
                        command.Parameters.AddWithValue("@MAHD", mahd);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đơn hàng đã được hủy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
