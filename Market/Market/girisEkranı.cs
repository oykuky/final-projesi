using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Market
{
    public partial class girisEkranı : Form

    {
        MarketAppDBEntities2 db = new MarketAppDBEntities2();
        public girisEkranı()
        {
            InitializeComponent();
        }

        private void giris_foto_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void k_adi_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_buton_Click(object sender, EventArgs e)
        {

        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string username = k_adi_txt.Text;
            string password = sifre_txt.Text;
            var user = db.MARKETs.FirstOrDefault(u => u.marketKADI == username && u.marketSIFRE == password);
            if (user != null)
            {
                // Log the user in and redirect them to the appropriate page
                MessageBox.Show("Hoş geldiniz " + username);
                this.Hide();
                Menu mainM = new Menu();
                mainM.Show();
                //redirect to the main page

            }
            else
            {
                // Display an error message to the user
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }

        

        private void design_foto_Click(object sender, EventArgs e)
        {

        }
    }
    }
