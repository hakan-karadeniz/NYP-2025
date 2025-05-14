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
    public partial class Manager_Classes11 : Form
    {
        public Manager_Classes11()
        {
            InitializeComponent();
        }
        private void Sinif9OgrencileriListele()
        {
            string connectionString = "Server=MORTY\\MSSQLSERVER02;Database=NYP2025;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Student_Info WHERE student_class = @sinif";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sinif", "11");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void Manager_Classes11_Load(object sender, EventArgs e)
        {
            Sinif9OgrencileriListele();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Classes anasayfa = new Manager_Classes();
            anasayfa.Show();
            this.Hide();
        }
    }
}
