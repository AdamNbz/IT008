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
using Color = System.Drawing.Color;

namespace Quan_ly_san_the_thao
{
    public partial class TimeSelection : Form
    {
        DataRow userData;
        private string currentSport, sportID;
        dynamic prev_sender = null;
        private decimal totalPrice = 0m;
        int selectedSlot;
        DateTime selectedDay = new DateTime();
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_DATABASE_PROJECT;Integrated Security=True";
        int selectedField;
        public TimeSelection(DataRow user, string sport)
        {
            InitializeComponent();
            this.userData = user;
            lb_TotalNeeded.Text = "Tổng tiền: 0VND";
            this.currentSport = (sport == "Bóng đá") ?       "BONGDA" :
                                (sport == "Bóng chuyền") ?   "BONGCHUYEN" :
                                (sport == "Bóng rổ") ?       "BONGRO" :
                                                             "CAULONG";
            selectedDay = DateTime.Today;
            UpdateVerifyButtonState();
            selectedSlot = 0;
        }

        private decimal ParsePrice(string priceText)
        {
            string numericText = new string(priceText.Where(c => char.IsDigit(c)).ToArray());
            if (decimal.TryParse(numericText, out decimal price))
            {
                return price;
            }
            return 0m;
        }

        private void UpdateSlots()
        {
            string query = @"SELECT C.KHUNGGIO, C.SANDAT
                             FROM SANTHETHAO STT JOIN CTHD C ON C.MASANTT = STT.MASANTT
                             WHERE C.NGHDHLUC = @Selected AND STT.MONTHETHAO = @currentSport"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Selected", selectedDay);
                cmd.Parameters.AddWithValue("@currentSport", currentSport);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string slotStr = reader["KHUNGGIO"].ToString();
                        int slot = int.Parse(slotStr);
                        string sanDat = reader.GetString(reader.GetOrdinal("SANDAT"));
                        MarkedSlot(slot, sanDat);
                    }
                }
            }
        }

        private void MarkedSlot(int slot, string sanDat)
        {
            for (int i = 0; i < sanDat.Length; i++)
            {
                if (sanDat[i] == '1')
                {
                    Button btn = this.Controls.Find($"btn_{slot}_{i + 1}", true).FirstOrDefault() as Button;
                    if (btn != null) btn.BackColor = Color.LightYellow;
                }
            }
        }

        private void mCd_calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDay = e.Start;
            if (selectedDay < DateTime.Today)
            {
                MessageBox.Show("Ngày đã chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedDay = DateTime.Today;
                return;
            }
            for (int i = 7; i <= 10; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = this.Controls.Find($"btn_{i}_{j}", true).FirstOrDefault() as Button;
                    if (btn != null) btn.BackColor = Color.White;
                }
            }
            for (int i = 13; i <= 16; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = this.Controls.Find($"btn_{i}_{j}", true).FirstOrDefault() as Button;
                    if (btn != null) btn.BackColor = Color.White;
                }
            }
            for (int i = 18; i <= 21; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = this.Controls.Find($"btn_{i}_{j}", true).FirstOrDefault() as Button;
                    if (btn != null) btn.BackColor = Color.White;
                }
            }
            UpdateSlots();
        }

        public void ColorizeSlotButtons(dynamic sender, EventArgs e)
        {
            Button currentBtn = sender as Button;
            string[] parts = currentBtn.Name.Split('_');
            int slot = int.Parse(parts[1]);
            int san = int.Parse(parts[2]);

            if (selectedSlot == 0 && selectedField == 0)
            {
                currentBtn.BackColor = Color.LightBlue;
                selectedSlot = slot;
                selectedField = san;
                totalPrice += GetSlotPrice(slot);
                lb_TotalNeeded.Text = "Tổng tiền: " + totalPrice.ToString("0.000VND");
                UpdateVerifyButtonState();
            }
            else
            {
                if (slot == selectedSlot && san == selectedField)
                {
                    currentBtn.BackColor = Color.White;
                    totalPrice -= GetSlotPrice(slot);
                    lb_TotalNeeded.Text = "Tổng tiền: " + totalPrice.ToString("0.000VND");

                    selectedSlot = 0;
                    selectedField = 0;
                    UpdateVerifyButtonState();
                }
                else
                {
                    MessageBox.Show("Bạn chỉ được chọn 1 slot và 1 sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private decimal GetSlotPrice(int slot)
        {
            if (slot >= 7 && slot <= 10)
            {
                return ParsePrice(lb_MorningPrice.Text);
            }
            else if (slot >= 13 && slot <= 16)
            {
                return ParsePrice(lb_AfternoonPrice.Text);
            }
            else
            {
                return ParsePrice(lb_EveningPrice.Text);
            }
        }

        private void UpdateVerifyButtonState()
        {
            btn_Verify.Enabled = (totalPrice > 0);
        }
        
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            string ID = Guid.NewGuid().ToString().Substring(0, 10).ToUpper();
            string paymentMethod = "none";
            int invoiceStatus = 0;

            string insertHoaDonQuery = @"INSERT INTO HOADON (MAHD, USERNAME, NGTTOAN, TRIGIA, MAGIAMGIA, PHUONGTHUCTT, TINHTRANGHD) 
                                 VALUES (@MAHD, @USERNAME, @NGTTOAN, @TRIGIA, @MAGIAMGIA, @PHUONGTHUCTT, @TINHTRANGHD)";
            string query = @"INSERT INTO CTHD (MAHD, MASANTT, NGHDHLUC, SANDAT, KHUNGGIO, MONTHETHAO)
                     VALUES (@MAHD, @MASANTT, @NGHDHLUC, @SANDAT, @KHUNGGIO, @SPORT)"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertHoaDonQuery, connection))
                {
                    command.Parameters.AddWithValue("@MAHD", ID);
                    command.Parameters.AddWithValue("@USERNAME", userData["USERNAME"]);
                    command.Parameters.AddWithValue("@TRIGIA", (int)((double)totalPrice * 1.08));
                    command.Parameters.AddWithValue("@NGTTOAN", DateTime.Today);
                    command.Parameters.AddWithValue("@MAGIAMGIA", DBNull.Value);
                    command.Parameters.AddWithValue("@PHUONGTHUCTT", paymentMethod);
                    command.Parameters.AddWithValue("@TINHTRANGHD", invoiceStatus);
                    command.ExecuteNonQuery();
                }

                char[] sandatArr = { '0', '0', '0' };
                sandatArr[selectedField - 1] = '1';
                string sandatStr = new string(sandatArr);
                string masantt = $"SANTT0{selectedField}";
                string khunggio = selectedSlot.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MAHD", ID);
                    command.Parameters.AddWithValue("@MASANTT", masantt);
                    command.Parameters.AddWithValue("@NGHDHLUC", selectedDay);
                    command.Parameters.AddWithValue("@SANDAT", sandatStr);
                    command.Parameters.AddWithValue("@KHUNGGIO", khunggio);
                    command.Parameters.AddWithValue("@SPORT", currentSport);
                    command.ExecuteNonQuery();
                }
            }
            Payment pay = new Payment(userData);
            this.Hide();
            pay.ShowDialog();
            this.Close();
        }

        private void Tsmi_ChangeSport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu(userData["USERNAME"].ToString());  // Create an instance of the MainMenu form
            mainMenu.Show();
        }

        private void TimeSelection_Shown(object sender, EventArgs e)
        {
            string sportShowing = currentSport;
            string query = "SELECT GTSANG, GTCHIEU, GTTOI, MASANTT FROM SANTHETHAO WHERE MONTHETHAO = @Sport";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Sport", sportShowing);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    decimal gtsang = reader.GetDecimal(reader.GetOrdinal("GTSANG"));
                    decimal gtchieu = reader.GetDecimal(reader.GetOrdinal("GTCHIEU"));
                    decimal gttoi = reader.GetDecimal(reader.GetOrdinal("GTTOI"));

                    string gtsangFormatted = $"{gtsang:0}VND";
                    string gtchieuFormatted = $"{gtchieu:0}VND";
                    string gttoiFormatted = $"{gttoi:0}VND";

                    lb_MorningPrice.Text = gtsangFormatted;
                    lb_AfternoonPrice.Text = gtchieuFormatted;
                    lb_EveningPrice.Text = gttoiFormatted;

                    sportID = reader.GetString(reader.GetOrdinal("MASANTT"));
                }
            }
            UpdateSlots();
        }
    }
}
