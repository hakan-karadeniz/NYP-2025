using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NesneProje
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Login anaform = new Manager_Login();
            anaform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Login anaform = new Student_Login();
            anaform.Show();
            this.Hide();
        }

        private void button_yoneticiGiris_MouseHover(object sender, EventArgs e)
        {
            button_yoneticiGiris.BackColor = Color.LightBlue;
        }

        private void button_yoneticiGiris_MouseLeave(object sender, EventArgs e)
        {
            button_yoneticiGiris.BackColor = Color.PowderBlue;
        }

        private void button_ogrGiris_MouseHover(object sender, EventArgs e)
        {
            button_ogrGiris.BackColor = Color.LightBlue;
        }

        private void button_ogrGiris_MouseLeave(object sender, EventArgs e)
        {
            button_ogrGiris.BackColor = Color.PowderBlue;
        }

        private void main_page_Load(object sender, EventArgs e)
        {
        }
    }
}
