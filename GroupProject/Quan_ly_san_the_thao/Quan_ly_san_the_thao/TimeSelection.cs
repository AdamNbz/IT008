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
    public partial class TimeSelection : Form
    {
        DataRow userData;
        private string currentSport, sportID;
        dynamic prev_sender = null;
        private decimal totalPrice = 0m;
        int selectedSlot;
        DateTime selectedDay = new DateTime();
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_DATABASE_PROJECT;Integrated Security=True";

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
            string query = @"SELECT C.KHUNGGIO
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
                        int slot = reader.GetByte(reader.GetOrdinal("KHUNGGIO"));
                        MarkedSlot(slot);
                    }
                }
            }
        }

        private void MarkedSlot(int slot)
        {
            if (slot >= 7 && slot <= 10)
            {
                for (int j = 7; j <= 10; j++)
                {
                    Button btn = this.Controls.Find("btn_" + j, true).FirstOrDefault() as Button;
                    if (btn != null && j == slot) btn.BackColor = Color.LightYellow;
                }
            }
            else if (slot >= 13 && slot <= 16)
            {
                for (int j = 13; j <= 16; j++)
                {
                    Button btn = this.Controls.Find("btn_" + j, true).FirstOrDefault() as Button;
                    if (btn != null && j == slot) btn.BackColor = Color.LightYellow;
                }
            }
            else
            {
                for (int j = 18; j <= 21; j++)
                {
                    Button btn = this.Controls.Find("btn_" + j, true).FirstOrDefault() as Button;
                    if (btn != null && j == slot) btn.BackColor = Color.LightYellow;
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
                Button btn = this.Controls.Find("btn_" + i, true).FirstOrDefault() as Button;
                btn.BackColor = Color.White;
            }
            for (int i = 13; i <= 16; i++)
            {
                Button btn = this.Controls.Find("btn_" + i, true).FirstOrDefault() as Button;
                btn.BackColor = Color.White;
            }
            for (int i = 18; i <= 21; i++)
            {
                Button btn = this.Controls.Find("btn_" + i, true).FirstOrDefault() as Button;
                btn.BackColor = Color.White;
            }
            UpdateSlots();
        }

        private void ColorizeSlotButtons(dynamic sender, EventArgs e)
        {
            if (sender.BackColor == Color.White)
            {
                sender.BackColor = Color.LightBlue;
                if (prev_sender == null)
                {
                    prev_sender = sender;
                }
                else
                {
                    prev_sender.BackColor = Color.White;
                    prev_sender = sender;
                }
            }
            else if (sender.BackColor == Color.LightBlue)
            {
                sender.BackColor = Color.White;
                prev_sender = null;
                totalPrice = 0;
                lb_TotalNeeded.Text = "Tổng tiền: 0VND";
                return;
            }
            else if (sender.BackColor == Color.LightYellow)
            {
                MessageBox.Show("Khung giờ này đã được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button currentBtn = sender as Button;
            string[] parts = currentBtn.Name.Split('_');
            selectedSlot = int.Parse(parts[1]);

            if (selectedSlot >= 7 && selectedSlot <= 10)
            {
                lb_TotalNeeded.Text = "Tổng tiền: " + lb_MorningPrice.Text;
                totalPrice = ParsePrice(lb_MorningPrice.Text);
            }
            else if (selectedSlot >= 13 && selectedSlot <= 16)
            {
                lb_TotalNeeded.Text = "Tổng tiền: " + lb_AfternoonPrice.Text;
                totalPrice = ParsePrice(lb_AfternoonPrice.Text);
            }
            else
            {
                lb_TotalNeeded.Text = "Tổng tiền: " + lb_EveningPrice.Text;
                totalPrice = ParsePrice(lb_EveningPrice.Text);
            }

            UpdateVerifyButtonState();
        }

        private void UpdateVerifyButtonState()
        {
            btn_Verify.Enabled = (totalPrice > 0);
        }
        
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            string ID = Guid.NewGuid().ToString().Substring(0, 10).ToUpper();

            string insertHoaDonQuery = @"INSERT INTO HOADON (MAHD, USERNAME, TRIGIA, NGTTOAN) VALUES (@MAHD, @USERNAME, @TRIGIA, @NGTTOAN)";
            string query = @"INSERT INTO CTHD (MAHD, MASANTT, NGHDHLUC, KHUNGGIO)
                             VALUES (@MAHD, @MASANTT, @NGHDHLUC, @TTGTSANG, @TTGTTRUA, @TTGTTOI, @Slot)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertHoaDonQuery, connection))
                {
                    command.Parameters.AddWithValue("@MAHD", ID);
                    command.Parameters.AddWithValue("@USERNAME", userData["USERNAME"]);
                    command.Parameters.AddWithValue("@TRIGIA", (int)((double)totalPrice*1.08));
                    command.Parameters.AddWithValue("@NGTTOAN", selectedDay.Date);
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MAHD", ID);
                    command.Parameters.AddWithValue("@MASANTT", sportID);
                    command.Parameters.AddWithValue("@NGHDHLUC", selectedDay);
                    command.Parameters.AddWithValue("@Slot", selectedSlot);
                    command.ExecuteNonQuery();
                }
            }
            Payment pay = new Payment(userData);
            this.Hide();
            pay.ShowDialog();
            this.Close();
        }

        private void TimeSelection_Shown(object sender, EventArgs e)
        {
            string sportShowing = currentSport;
            string query = "SELECT GTSANG, GTTRUA, GTTOI, MASANTT FROM SANTHETHAO WHERE MONTHETHAO = @Sport";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Sport", sportShowing);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    decimal gtsang = reader.GetDecimal(reader.GetOrdinal("GTSANG"));
                    decimal gttrua = reader.GetDecimal(reader.GetOrdinal("GTTRUA"));
                    decimal gttoi = reader.GetDecimal(reader.GetOrdinal("GTTOI"));

                    string gtsangFormatted = $"{gtsang:0}.000VND";
                    string gttruaFormatted = $"{gttrua:0}.000VND";
                    string gttoiFormatted = $"{gttoi:0}.000VND";

                    lb_MorningPrice.Text = gtsangFormatted;
                    lb_AfternoonPrice.Text = gttruaFormatted;
                    lb_EveningPrice.Text = gttoiFormatted;

                    sportID = reader.GetString(reader.GetOrdinal("MASANTT"));
                }
            }
            UpdateSlots();
        }
    }
}
