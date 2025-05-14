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
    public partial class Manager_LoginNotes : Form
    {
        public Manager_LoginNotes()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO Lessons_Info (matematik, fizik, kimya,student_no, biyoloji) " +
                                 "VALUES (@mat, @fizik, @kimya, @no, @biyoloji)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mat", textBox_matematik.Text);
                        cmd.Parameters.AddWithValue("@fizik", textBox_fizik.Text);
                        cmd.Parameters.AddWithValue("@kimya", textBox_kimya.Text);
                        cmd.Parameters.AddWithValue("@no", textBox_stdNo.Text);
                        cmd.Parameters.AddWithValue("@biyoloji", textBox_biyoloji.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Notlar başarıyla eklendi!");
                        else
                            MessageBox.Show("Ekleme başarısız.");
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
