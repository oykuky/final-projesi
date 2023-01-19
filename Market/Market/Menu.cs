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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void FormGetir(Form fm)
        {
            panelBolum.Controls.Clear();
            fm.MdiParent = this;
            fm.FormBorderStyle = FormBorderStyle.None;
            panelBolum.Controls.Add(fm);
            fm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Musteri MFgetir= new Musteri();
            FormGetir(MFgetir);
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Urun UFgetir = new Urun();
            FormGetir(UFgetir);
        }

        //FORMLAR EKLENINCE DUZENLE

        //private void btnSatıslar_Click(object sender, EventArgs e)
        //{
        //    SatısFormu SFgetir = new SatısFormu();
        //    FormGetir(SFgetir);
        //}

        //private void btnTedarikciler_Click(object sender, EventArgs e)
        //{
        //    TedarikciForm TFgetir = new TedarikciForm();
        //    FormGetir(TFgetir);
        //}

        //private void btnMarket_Click(object sender, EventArgs e)
        //{
        //    MarketForm MFgetir = new MarketForm();
        //    FormGetir(MFgetir);
        //}

        //private void btnRaporlama_Click(object sender, EventArgs e)
        //{
        //    RaporForm RFgetir = new RaporForm();
        //    FormGetir(RFgetir);
        //}

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Çıkmak istiyor musunuz?","Çıkış Yap",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                this.Close(); 
            }
           

            
        }

        
    }
}
