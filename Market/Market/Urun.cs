using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Market
{
    public partial class Urun : Form
    {
        MarketAppDBEntities2 db= new MarketAppDBEntities2();
        public Urun()
        {
            InitializeComponent();
        }

        //Form yüklendiğinde Urunler tablosundan ürünleri listele yükle
        private void Urun_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = db.PRODUCTs.ToList();
            dgvUrunler.Columns[0].HeaderText = "Urun Kodu";
            dgvUrunler.Columns[1].HeaderText = "Urun Adı";
            dgvUrunler.Columns[2].HeaderText = "Fiyat"; 
            dgvUrunler.Columns[3].HeaderText = "Miktar";
            dgvUrunler.Columns[4].Visible = false; //marketId ve SId gizlendi
            dgvUrunler.Columns[5].Visible = false;

        }

        //dgvUrunlerde hücreye tıklandığında grupBoxa veri getirme
        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textUrunKod.Text= dgvUrunler.CurrentRow.Cells[0].Value.ToString();
            textUadi.Text= dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            textFiyat.Text= dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            textMiktar.Text= dgvUrunler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //urun fiyatı ve adını güncelleme
            int id = Convert.ToInt32(textUrunKod.Text);
            var d = db.PRODUCTs.Find(id);
            d.costPRICE = Convert.ToInt32(textFiyat.Text);// texte yazılan veriyi databasede güncelle
            d.productNAME = textUadi.Text;
            db.SaveChanges();
            MessageBox.Show("Satış Fiyatı oluşturuldu,Güncellendi");
            //textboxları temizleme
            textUrunKod.Text ="";
            textUadi.Text ="";
            textFiyat.Text ="";
            textMiktar.Text ="";

        }
        
        //STOK İŞLEME TAMAMLANMADI
        //private void btnStokİsle_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "txt dosyaları|*.txt";
        //    openFileDialog1.Title = "Text dosyası açın";
        //    DialogResult cevap = openFileDialog1.ShowDialog();
        //    if (cevap == DialogResult.OK)
        //    {
        //        string file = openFileDialog1.FileName;
                
        //    }


        //}

    }
}
