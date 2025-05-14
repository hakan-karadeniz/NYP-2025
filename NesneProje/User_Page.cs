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
    public partial class User_Page : Form
    {
        public User_Page()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Student_Login anasayfa = new Student_Login();
            anasayfa.Show();
            this.Hide();
        }

        private void button_lessons_Click(object sender, EventArgs e)
        {
            Student_Lessons anasayfa = new Student_Lessons();
            anasayfa.Show();
            this.Hide();
        }

        private void button_stdInfo_Click(object sender, EventArgs e)
        {
            Student_Information anasayfa = new Student_Information();
            anasayfa.Show();
            this.Hide();
        }
    }
}
