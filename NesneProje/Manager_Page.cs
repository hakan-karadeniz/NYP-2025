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
    public partial class Manager_Page : Form
    {
        public Manager_Page()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Manager_Login anasayfa = new Manager_Login();
            anasayfa.Show();
            this.Hide();
        }

        private void button_newStdRegis_Click(object sender, EventArgs e)
        {
            Manager_NewStudent anasayfa = new Manager_NewStudent();
            anasayfa.Show();
            this.Hide();
        }

        private void button_stdDelete_Click(object sender, EventArgs e)
        {
            Manager_StudentDelete anasayfa = new Manager_StudentDelete();
            anasayfa.Show();
            this.Hide();
        }

        private void button_stdUpdate_Click(object sender, EventArgs e)
        {
            Manager_StudentUpdate anasayfa = new Manager_StudentUpdate();
            anasayfa.Show();
            this.Hide();
        }

        private void button_classes_Click(object sender, EventArgs e)
        {
            Manager_Classes anasayfa = new Manager_Classes();
            anasayfa.Show();
            this.Hide();
        }

        private void button_stdNotes_Click(object sender, EventArgs e)
        {
            Manager_LoginNotes anasayfa = new Manager_LoginNotes();
            anasayfa.Show();
            this.Hide();
        }

        private void button_notUpdates_Click(object sender, EventArgs e)
        {
            Manager_NotesUpdates anasayfa = new Manager_NotesUpdates();
            anasayfa.Show();
            this.Hide();
        }
    }
}
