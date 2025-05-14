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
    public partial class Manager_StudentUpdate : Form
    {
        public Manager_StudentUpdate()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Page anasayfa = new Manager_Page();
            anasayfa.Show();
            this.Hide();
        }

        string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"UPDATE Student_Info 
                           SET student_name = @name, 
                               student_surname = @surname, 
                               student_tc = @tc, 
                               student_veliNo = @veliTel, 
                               student_class = @sinif, 
                               student_sube = @sube 
                           WHERE student_no = @no"; 

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox_stdname.Text);
                        cmd.Parameters.AddWithValue("@surname", textBox_stdsurname.Text);
                        cmd.Parameters.AddWithValue("@tc", textBox_stdtc.Text);
                        cmd.Parameters.AddWithValue("@veliTel", textBox_stdvelino.Text);
                        cmd.Parameters.AddWithValue("@sinif", textBox_stdclass.Text);
                        cmd.Parameters.AddWithValue("@sube", textBox_stdsube.Text);

                        cmd.Parameters.AddWithValue("@no", textBox_stdno.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
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

        private void button_getir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT student_name, student_surname, student_tc, student_veliNo, student_class, student_sube FROM Student_Info WHERE student_no = @no";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", textBox_stdno.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())  
                        {
                            textBox_stdname.Text = reader["student_name"].ToString();
                            textBox_stdsurname.Text = reader["student_surname"].ToString();
                            textBox_stdtc.Text = reader["student_tc"].ToString();
                            textBox_stdvelino.Text = reader["student_veliNo"].ToString();
                            textBox_stdclass.Text = reader["student_class"].ToString();
                            textBox_stdsube.Text = reader["student_sube"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu numaraya sahip öğrenci bulunamadı.");
                        }
                    }
                    textBox_stdname.Enabled = true;
                    textBox_stdsurname.Enabled = true;
                    textBox_stdtc.Enabled = true;
                    textBox_stdvelino.Enabled = true;
                    textBox_stdclass.Enabled = true;
                    textBox_stdsube.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
