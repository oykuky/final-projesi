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
    public partial class MustBorcOdeme : Form
    {
        public MustBorcOdeme()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            cvp = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Müşteri aramaması yapılıp müşterinin satın almaları dgv de listelenicek
        //Toplam borcu getirilicek
        private void btnMgetir_Click(object sender, EventArgs e)
        {
            int mId = Convert.ToInt32(textBMusId.Text); //TextBoxa yazılan değer mId de tutulucak
            //buraya satın alınanları getiren sorgu gelicek



        }

        //ödeme işlemi yapılacak ve kalan borç miktarı görüntülencek
        private void btnOde_Click(object sender, EventArgs e)
        {

        }
    }
}
