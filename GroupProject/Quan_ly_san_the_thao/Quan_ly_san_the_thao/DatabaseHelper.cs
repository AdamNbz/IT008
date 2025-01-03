using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeCalls;

namespace Quan_ly_san_the_thao
{
    public class DatabaseHelper
    {
        private string sqlConnectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_DATABASE_PROJECT;Integrated Security=True";

        public DataRow GetCredentials(string username)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT USERNAME, PASSWRD FROM KHACHHANG WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }

        public DataRow GetUserDetails(string username)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT * FROM KHACHHANG WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }

        public bool VerifyCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME = @Username AND PASSWRD = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME = @Username";

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool InsertNewUser(string username, string password, string fullName, string email, string phoneNumber, bool gender)
        {
            string query = @"
            INSERT INTO KHACHHANG (USERNAME, PASSWRD, TENKH, EMAIL, SDT, GTINH)
            VALUES (@Username, @Password, @FullName, @Email, @PhoneNumber, @Gender)";

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool CheckPhoneNumberExists(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT = @PhoneNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = @"UPDATE KHACHHANG
                                 SET PASSWRD = @NewPassword
                                 WHERE USERNAME = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool SendPasswordResetRequest(string username)
        {
            string query = "INSERT INTO THONGBAO (MATB, USERNAME, LOAITB, NOIDUNGTB) VALUES (@MATB, @USERNAME, @LOAITB, @NOIDUNGTB)";
            string matb = GenerateMATB();

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MATB", matb);
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@LOAITB", 1);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        private string GenerateMATB()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        public int GetCustomerCount()
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count - 1;
            }
        }

        public List<decimal> GetFieldPrice(string type)
        {
            List<decimal> result = new List<decimal>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT GTSANG, GTCHIEU, GTTOI FROM SANTHETHAO WHERE MASANTT = @type";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@type", type);

                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    result.Add(read.GetDecimal(read.GetOrdinal("GTSANG")));
                    result.Add(read.GetDecimal(read.GetOrdinal("GTCHIEU")));
                    result.Add(read.GetDecimal(read.GetOrdinal("GTTOI")));
                }
                read.Close();
            }
            return result;
        }

        public void UpdateFieldPrice(string type, decimal morning, decimal afternoon, decimal evening)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "UPDATE SANTHETHAO SET GTSANG = @morning, GTCHIEU = @afternoon, GTTOI = @evening WHERE MASANTT = @type";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@morning", morning);
                cmd.Parameters.AddWithValue("@afternoon", afternoon);
                cmd.Parameters.AddWithValue("@evening", evening);
                cmd.Parameters.AddWithValue("@type", type);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void SendDepositRequest(string username, decimal amount)
        {
            string query = "INSERT INTO THONGBAO (MATB, USERNAME, LOAITB) VALUES (@MATB, @USERNAME, @LOAITB)";
            string matb = GenerateMATB();
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MATB", matb);
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@LOAITB", 0);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCustomerBalance(string username, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "UPDATE KHACHHANG SET SODU = SODU + @Amount WHERE USERNAME = @Username";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Username", username);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCustomerList()
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT KH.USERNAME as Username, KH.TENKH as TenKH, KH.EMAIL as Email, KH.SDT as SDT, ISNULL(COUNT(HD.MAHD), 0) as SLHoaDon, ISNULL(LOAITB, 0) as TrangThaiRequest" +
                     " FROM KHACHHANG KH" +
                     " LEFT JOIN THONGBAO TB ON KH.USERNAME = TB.USERNAME" +
                     " LEFT JOIN HOADON HD ON KH.USERNAME = HD.USERNAME" +
                     " WHERE KH.USERNAME <> 'admin'" +
                     " GROUP BY KH.USERNAME, KH.TENKH, KH.EMAIL, KH.SDT, LOAITB";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                connection.Open();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetCouponList()
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT GG.MAGIAMGIA, STT.MONTHETHAO, GG.HESO, GG.TGHIEULUC " +
                    " FROM GIAMGIA GG" +
                    " LEFT JOIN HOADON HD ON GG.MAGIAMGIA = HD.MAGIAMGIA" +
                    " LEFT JOIN CTHD CT ON HD.MAHD = CT.MAHD" +
                    " LEFT JOIN SANTHETHAO STT ON CT.MASANTT = STT.MASANTT" +
                    " GROUP BY GG.MAGIAMGIA, STT.MONTHETHAO, GG.HESO, GG.TGHIEULUC";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                connection.Open();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AddCoupon(string couponCode, decimal discount, DateTime endTime)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "INSERT INTO GIAMGIA (MAGIAMGIA, HESO, TGHIEULUC) VALUES (@CouponCode, @Discount, @EndTime)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CouponCode", couponCode);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCoupon(string couponCode)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "DELETE FROM GIAMGIA WHERE MAGIAMGIA = @CouponCode";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CouponCode", couponCode);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCouponStatus()
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "DELETE FROM GIAMGIA WHERE TGHIEULUC < GETDATE()";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetBillList()
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT HD.MAHD, HD.USERNAME, CT.NGHDHLUC, CT.KHUNGGIO, CT.SANDAT, HD.TRIGIA, HD.TINHTRANGHD, GG.HESO" +
                    " FROM HOADON HD" +
                    " JOIN CTHD CT ON HD.MAHD = CT.MAHD" +
                    " LEFT JOIN GIAMGIA GG ON HD.MAGIAMGIA = GG.MAGIAMGIA";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                connection.Open();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string khungGio = row["KHUNGGIO"].ToString();
                    string sanDat = row["SANDAT"].ToString();

                    string[] timeSlots = khungGio.Split('_');
                    string formattedTimeSlots = string.Join(", ", timeSlots);
                    formattedTimeSlots += "g";

                    string formattedSanDat = "Sân";
                    if (sanDat.Length == 3)
                    {
                        if (sanDat[0] == '1') formattedSanDat += " 1,";
                        if (sanDat[1] == '1') formattedSanDat += " 2,";
                        if (sanDat[2] == '1') formattedSanDat += " 3";
                    }

                    row["KHUNGGIO"] = formattedTimeSlots;
                    row["SANDAT"] = formattedSanDat;

                    decimal originalPrice = Convert.ToDecimal(row["TRIGIA"]);
                    decimal discountRate = row["HESO"] != DBNull.Value ? Convert.ToDecimal(row["HESO"]) : 0;
                    decimal finalPrice = originalPrice * (1 - discountRate);
                    row["TRIGIA"] = finalPrice;
                }
                return dataTable;
            }
        }

        public void UpdateBillStatus(string billID, string stat)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                string query = "SELECT TINHTRANGHD FROM HOADON WHERE MAHD = @BillId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BillId", billID);
                connection.Open();
                int currentStatus = (int)cmd.ExecuteScalar();

                int newStatus = stat == "1" ? 1 : 0;

                query = "UPDATE HOADON SET TINHTRANGHD = @NewStatus WHERE MAHD = @BillId";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                cmd.Parameters.AddWithValue("@BillId", billID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
