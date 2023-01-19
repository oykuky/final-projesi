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
    public partial class Musteri : Form
    {

        public Musteri()
        {
            InitializeComponent();
        }

        MarketAppDBEntities2 db = new MarketAppDBEntities2();
        private void btOde_Click(object sender, EventArgs e) //Butona tıklandığında Musteri borç ödeme formu açılsın
        {   
            MustBorcOdeme BOd = new MustBorcOdeme();
            this.Hide();
            BOd.Show();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = db.CUSTOMERs.ToList();
            dgvMusteriler.Columns[0].HeaderText = "Müşteri ID";
            dgvMusteriler.Columns[1].HeaderText = "Müşteri Ad Soyad";
            dgvMusteriler.Columns[3].HeaderText = "Borç Miktarı";
            dgvMusteriler.Columns[2].Visible = false; 
            dgvMusteriler.Columns[4].Visible = false;
            dgvMusteriler.Columns[5].Visible = false;
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMusId.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
            textBoxAdS.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
            textBoxBorcMiktr.Text = dgvMusteriler.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CUSTOMER musteriEkle = new CUSTOMER();
            musteriEkle.customerID = Convert.ToInt32(textBoxMusId.Text);
            musteriEkle.customerNAME = textBoxAdS.Text;
            musteriEkle.customerDEBT = Convert.ToDouble(textBoxBorcMiktr.Text);

            db.CUSTOMERs.Add(musteriEkle);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı,Müşteri eklendi.");
            dgvMusteriler.DataSource = db.CUSTOMERs.ToList(); //Musterileri listele
            foreach(Control item in Controls) // textbox temizleme
            {
                if (item is TextBox ) item.Text= "";
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int MusID = Convert.ToInt32(textBoxMusId.Text); // textboxa yazilan ıd ye göre işlem yapılıcak
            var guncelle = db.CUSTOMERs.Where(w => w.customerID == MusID).FirstOrDefault();
            guncelle.customerNAME= textBoxAdS.Text;
            guncelle.customerDEBT= Convert.ToDouble(textBoxBorcMiktr.Text);// ?
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgileri güncellendi.");
            dgvMusteriler.DataSource= db.CUSTOMERs.ToList();
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //int MusID_2 = Convert.ToInt32(textBoxMusId.Text); 
            int MusID = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);
            //dgvMusterilerde seçilen ıd ye göre işlemi uygular
            
            var sil = db.CUSTOMERs.Where(w => w.customerID==MusID).FirstOrDefault();
            db.CUSTOMERs.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Müşteri silindi.");
            dgvMusteriler.DataSource = db.CUSTOMERs.ToList();
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

        }
    }
}
