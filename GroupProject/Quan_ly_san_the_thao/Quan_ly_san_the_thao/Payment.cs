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
using Twilio.TwiML.Voice;

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

            string query = @"
                SELECT TOP 1 
                       HD.MAHD, 
                       HD.NGTTOAN, 
                       HD.TRIGIA, 
                       C.MONTHETHAO, 
                       C.KHUNGGIO,
                       C.SANDAT
                FROM HOADON HD
                JOIN CTHD C ON HD.MAHD = C.MAHD
                WHERE HD.USERNAME = @username
                ORDER BY HD.NGTTOAN DESC
            ";

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
                            mahd = reader["MAHD"].ToString();
                            lb_ID.Text = mahd;

                            DateTime reserveDate = reader.GetDateTime(reader.GetOrdinal("NGTTOAN"));
                            lb_ReserveDate.Text = reserveDate.ToShortDateString();

                            decimal trigia = reader.GetDecimal(reader.GetOrdinal("TRIGIA"));
                            lb_Total.Text = $"{trigia:0}.000VND";

                            string sport = reader["MONTHETHAO"].ToString();
                            lb_Subject.Text = (sport == "BONGDA") ? "Bóng đá" :
                                              (sport == "BONGCHUYEN") ? "Bóng chuyền" :
                                              (sport == "BONGRO") ? "Bóng rổ" :
                                                                        "Cầu lông";

                            int slot = Convert.ToInt32(reader["KHUNGGIO"]);
                            lb_ReserveDate.Text += $" {slot}g";

                            string sandat = reader["SANDAT"].ToString();
                            int idx = sandat.IndexOf('1');
                            if (idx >= 0) lb_Field.Text = $"Sân {idx + 1}";
                        }
                        else
                        {
                            MessageBox.Show("Chưa có hóa đơn nào cho tài khoản này!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
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
                if (cb_payment.SelectedIndex == 1)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();
                        SqlTransaction transaction = connect.BeginTransaction();

                        decimal sodu = 0m;
                        string getSoduQuery = "SELECT SODU FROM KHACHHANG WHERE USERNAME = @username";
                        using (SqlCommand cmd = new SqlCommand(getSoduQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@username", userData["USERNAME"].ToString());
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    sodu = reader.GetDecimal(reader.GetOrdinal("SODU"));
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy thông tin khách hàng!",
                                                    "Lỗi",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                            }
                        }

                        decimal trigia = 0m;
                        string getTrigiaQuery = "SELECT TRIGIA FROM HOADON WHERE MAHD = @mahd";
                        using (SqlCommand cmd = new SqlCommand(getTrigiaQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@mahd", mahd);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    trigia = reader.GetDecimal(reader.GetOrdinal("TRIGIA"));
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy hóa đơn!",
                                                    "Lỗi",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                            }
                        }

                        if (sodu >= trigia)
                        {
                            decimal newSodu = sodu - trigia;
                            string updateSoduQuery = "UPDATE KHACHHANG SET SODU = @newSodu WHERE USERNAME = @username";
                            using (SqlCommand cmd = new SqlCommand(updateSoduQuery, connect, transaction))
                            {
                                cmd.Parameters.AddWithValue("@newSodu", newSodu);
                                cmd.Parameters.AddWithValue("@username", userData["USERNAME"].ToString());
                                cmd.ExecuteNonQuery();
                            }

                            string updateTinhTrangQuery = "UPDATE HOADON SET TINHTRANGHD = 1, PHUONGTHUCTT = 'dùng SODU' WHERE MAHD = @mahd";
                            using (SqlCommand cmd = new SqlCommand(updateTinhTrangQuery, connect, transaction))
                            {
                                cmd.Parameters.AddWithValue("@mahd", mahd);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Thanh toán thành công!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Số dư không đủ!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();
                        SqlTransaction transaction = connect.BeginTransaction();
                        string updateTinhTrangQuery = "UPDATE HOADON SET PHUONGTHUCTT = 'CK' WHERE MAHD = @mahd";
                        using (SqlCommand cmd = new SqlCommand(updateTinhTrangQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@mahd", mahd);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    MessageBox.Show("Đã gửi yêu cầu kiểm tra thanh toán CK đến quản trị viên!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
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

        private void btn_Coupon_Click(object sender, EventArgs e)
        {
            string couponCode = tb_Coupon.Text.Trim();
            if (string.IsNullOrEmpty(couponCode))
            {
                MessageBox.Show("Bạn chưa nhập mã giảm giá!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string checkCurrentHD = @"
                SELECT MAGIAMGIA
                FROM HOADON
                WHERE MAHD = @mahd
            ";

            string existingCoupon = null;
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(checkCurrentHD, connect))
                {
                    cmd.Parameters.AddWithValue("@mahd", mahd);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        existingCoupon = result.ToString();
                    }
                }
            }

            if (!string.IsNullOrEmpty(existingCoupon))
            {
                if (existingCoupon == couponCode)
                {
                    MessageBox.Show("Hóa đơn này đã áp dụng mã giảm giá bạn vừa nhập!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Hóa đơn này đã áp dụng một mã giảm giá khác!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
            }

            decimal discountRate = 0m;
            bool couponFound = false;

            string queryCheck = @"SELECT MAGIAMGIA, HESO 
                          FROM GIAMGIA
                          WHERE MAGIAMGIA = @coupon";
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(queryCheck, connect))
                {
                    cmd.Parameters.AddWithValue("@coupon", couponCode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hesoStr = reader["HESO"].ToString().Trim();
                            if (decimal.TryParse(hesoStr, out decimal parsedDecimal))
                            {
                                discountRate = parsedDecimal;
                                couponFound = true;
                            }
                        }
                    }
                }
            }
            if (!couponFound)
            {
                MessageBox.Show("Mã giảm giá không tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            decimal oldTrigia = 0m;
            if (decimal.TryParse(lb_Total.Text.Replace("VND", ""), out oldTrigia))
            {
                decimal newTrigia = oldTrigia * 1.08m * (1 - discountRate);
                decimal finalTrigia = Math.Round(newTrigia, 0);
                string queryUpdateHD = @"UPDATE HOADON 
                                 SET MAGIAMGIA = @coupon, 
                                     TRIGIA = @newTrigia
                                 WHERE MAHD = @mahd";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(queryUpdateHD, connect))
                    {
                        cmd.Parameters.AddWithValue("@coupon", couponCode);
                        cmd.Parameters.AddWithValue("@newTrigia", finalTrigia);
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.ExecuteNonQuery();
                    }
                }
                lb_Total.Text = $"{finalTrigia:0}.000VND";
                MessageBox.Show("Áp dụng mã giảm giá thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đọc được trị giá cũ!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pb_QR_VisibleChanged(object sender, EventArgs e)
        {
            if (cb_payment.SelectedIndex == 0) pb_QR.Visible = true;
            else pb_QR.Visible = false;
        }

        private void lb_CKNote_VisibleChanged(object sender, EventArgs e)
        {
            if (cb_payment.SelectedIndex == 0) lb_CKNote.Visible = true;
            else lb_CKNote.Visible = false;
        }

        private void cb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_QR_VisibleChanged(sender, e);
            lb_CKNote_VisibleChanged(sender, e);
        }
    }
}
