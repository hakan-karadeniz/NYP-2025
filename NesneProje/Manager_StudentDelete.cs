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
    public partial class Manager_StudentDelete : Form
    {
        public Manager_StudentDelete()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Page anasayfa = new Manager_Page();
            anasayfa.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DialogResult result = MessageBox.Show("Bu öğrenciyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                try
                {
                    conn.Open();

                    string sql = "DELETE FROM Student_Info WHERE student_no = @no";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", textBox_stdNo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Öğrenci başarıyla silindi.");
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
    }
}
