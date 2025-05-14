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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesneProje
{
    public partial class Student_Information : Form
    {
        public Student_Information()
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

        private void Student_Information_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT student_name, student_surname, student_tc, student_no, student_veliNo, student_class, student_sube " +
                               "FROM Student_Info WHERE student_no = @student_no";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@student_no", Student_Login.OgrNo); 

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        textBox_stdName.Text = dataTable.Rows[0]["student_name"].ToString();
                        textBox_stdSurname.Text = dataTable.Rows[0]["student_surname"].ToString();
                        textBox_stdTc.Text = dataTable.Rows[0]["student_tc"].ToString();
                        textBox_stdNo.Text = dataTable.Rows[0]["student_no"].ToString();
                        textBox_stdVeliNo.Text = dataTable.Rows[0]["student_veliNo"].ToString();
                        textBox_stdClass.Text = dataTable.Rows[0]["student_class"].ToString();
                        textBox_stdSube.Text = dataTable.Rows[0]["student_sube"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri bulunamadı.");
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
