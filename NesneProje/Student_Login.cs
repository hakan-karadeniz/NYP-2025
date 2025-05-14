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

namespace NesneProje
{
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
            kontrolEt();
        }

        private void kontrolEt()
        {
            bool hepsiDolu = !string.IsNullOrWhiteSpace(textBox_stdNo.Text)
                && !string.IsNullOrWhiteSpace(textBox_stdtc.Text);
            button_enter.Enabled = hepsiDolu;
        }
        private void Student_Login_MouseHover(object sender, EventArgs e)
        {
            button_enter.BackColor = Color.LightBlue;
        }

        private void Student_Login_MouseLeave(object sender, EventArgs e)
        {
            button_enter.BackColor = Color.PowderBlue;
        }

        private void textBox_stdNo_TextChanged(object sender, EventArgs e)
        {
            kontrolEt();
        }

        private void textBox_stdParola_TextChanged(object sender, EventArgs e)
        {
            kontrolEt();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            main_page anasayfa = new main_page();
            anasayfa.Show();
            this.Hide();
        }
        public static string OgrNo { get; set; }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";
            OgrNo = textBox_stdNo.Text.Trim();
            string ogrTc = textBox_stdtc.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Student_Info WHERE student_no = @no AND student_tc = @tc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@no", OgrNo);
                    cmd.Parameters.AddWithValue("@tc", ogrTc);

                    int kayitSayisi = (int)cmd.ExecuteScalar();

                    if (kayitSayisi > 0)
                    {
                        User_Page form = new User_Page();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci numarası veya TC yanlış!");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Login_Load(object sender, EventArgs e)
        {
            string imagePath = "pngwing.com (1).png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
