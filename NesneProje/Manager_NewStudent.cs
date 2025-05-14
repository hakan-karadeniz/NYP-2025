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
using System.Xml.Linq;

namespace NesneProje
{
    public partial class Manager_NewStudent : Form
    {
        public Manager_NewStudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO Student_Info (student_name, student_surname, student_tc, student_no, student_veliNo, student_class, student_sube) " +
                                 "VALUES (@name, @surname, @tc, @no, @veliTel, @sinif, @sube)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox_stdName.Text);
                        cmd.Parameters.AddWithValue("@surname", textBox_stdSurname.Text);
                        cmd.Parameters.AddWithValue("@tc", textBox_stdTc.Text);
                        cmd.Parameters.AddWithValue("@no", textBox_stdNo.Text);
                        cmd.Parameters.AddWithValue("@veliTel", textBox_stdVeliNo.Text);
                        cmd.Parameters.AddWithValue("@sinif", textBox_stdClass.Text);
                        cmd.Parameters.AddWithValue("@sube", textBox_stdSube.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Öğrenci başarıyla eklendi!");
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
