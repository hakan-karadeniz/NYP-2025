using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public partial class Manager_Classes : Form
    {
        public Manager_Classes()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Page anasayfa = new Manager_Page();
            anasayfa.Show();
            this.Hide();
        }

        private void button_dokuz_Click(object sender, EventArgs e)
        {
            Manager_Classes9 anasayfa = new Manager_Classes9();
            anasayfa.Show();
            this.Hide();
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            Manager_Classes10 anasayfa = new Manager_Classes10();
            anasayfa.Show();
            this.Hide();
        }

        private void button_onbir_Click(object sender, EventArgs e)
        {
            Manager_Classes11 anasayfa = new Manager_Classes11();
            anasayfa.Show();
            this.Hide();
        }

        private void button_oniki_Click(object sender, EventArgs e)
        {
            Manager_Classes12 anasayfa = new Manager_Classes12();
            anasayfa.Show();
            this.Hide();
        }
    }
}
