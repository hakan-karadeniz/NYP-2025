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
    public partial class Manager_NotesUpdates : Form
    {
        public Manager_NotesUpdates()
        {
            InitializeComponent();
        }
        string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

        private void button_getir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT matematik, fizik, kimya, biyoloji FROM Lessons_Info WHERE student_no = @no";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", textBox_stdNo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            textBox_matematik.Text = reader["matematik"].ToString();
                            textBox_fizik.Text = reader["fizik"].ToString();
                            textBox_kimya.Text = reader["kimya"].ToString();
                            textBox_biyoloji.Text = reader["biyoloji"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu numaraya sahip öğrenci bulunamadı.");
                        }
                    }
                    textBox_matematik.Enabled = true;
                    textBox_fizik.Enabled = true;
                    textBox_kimya.Enabled = true;
                    textBox_biyoloji.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"UPDATE Lessons_Info 
                           SET matematik = @mat, 
                               fizik = @fizik, 
                               kimya = @kimya, 
                               biyoloji = @biyoloji  
                           WHERE student_no = @no"; 

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mat", textBox_matematik.Text);
                        cmd.Parameters.AddWithValue("@fizik", textBox_fizik.Text);
                        cmd.Parameters.AddWithValue("@kimya", textBox_kimya.Text);
                        cmd.Parameters.AddWithValue("@biyoloji", textBox_biyoloji.Text);
                        cmd.Parameters.AddWithValue("@no", textBox_stdNo.Text);

                                int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Not bilgileri başarıyla güncellendi.");
                        else
                            MessageBox.Show("Bu numaraya sahip öğrenci bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Page anasayfa = new Manager_Page();
            anasayfa.Show();
            this.Hide();
        }
    }
}
