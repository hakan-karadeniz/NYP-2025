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
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
            kontrolEt();
        }
        private void kontrolEt()
        {
            bool hepsiDolu = !string.IsNullOrWhiteSpace(textBox_managerName.Text)
                && !string.IsNullOrWhiteSpace(textBox_managerParola.Text);
            button_enter.Enabled = hepsiDolu;
        }

        private void button_enter_MouseHover(object sender, EventArgs e)
        {
            button_enter.BackColor = Color.LightBlue;
        }

        private void button_enter_MouseLeave(object sender, EventArgs e)
        {
            button_enter.BackColor = Color.PowderBlue;
        }

        private void textBox_managerName_TextChanged(object sender, EventArgs e)
        {
            kontrolEt();
        }

        private void textBox_managerParola_TextChanged(object sender, EventArgs e)
        {
            kontrolEt();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string manageName = "hakan";
            string manageParola = "1967";

            if ((manageName == textBox_managerName.Text) && (manageParola == textBox_managerParola.Text))
            {
                Manager_Page anasayfa = new Manager_Page();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış Tekrar Dene!!");
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            main_page anasayfa = new main_page();
            anasayfa.Show();
            this.Hide();
        }

        private void Manager_Login_Load(object sender, EventArgs e)
        {
            string imagePath = "pngwing.com (2).png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
