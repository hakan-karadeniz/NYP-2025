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
    public partial class Student_Lessons : Form
    {
        public Student_Lessons()
        {
            InitializeComponent();
        }
        string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

        private void button_back_Click(object sender, EventArgs e)
        {
            User_Page anasayfa = new User_Page();
            anasayfa.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Student_Lessons_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT matematik, fizik, kimya, biyoloji FROM Lessons_Info WHERE student_no = @student_no";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@student_no", Student_Login.OgrNo);  // Student_Login'den alınan OgrNo

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open(); 
                    dataAdapter.Fill(dataTable); 

                    if (dataTable.Rows.Count > 0)
                    {
                        textBox_matematik.Text = dataTable.Rows[0]["matematik"].ToString();
                        textBox_fizik.Text = dataTable.Rows[0]["fizik"].ToString();
                        textBox_kimya.Text = dataTable.Rows[0]["kimya"].ToString();
                        textBox_biyoloji.Text = dataTable.Rows[0]["biyoloji"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci ders bilgileri bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
