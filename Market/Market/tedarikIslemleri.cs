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
    public partial class tedarikIslemleri : Form
    {
        public tedarikIslemleri()
        {
            InitializeComponent();
        }

        private void toplam_borc_Click(object sender, EventArgs e)
        {
            using (var db = new YourDbContext())
            {
                decimal totalDebt = (from s in db.Suppliers
                                     join m in db.Markets on s.MarketId equals m.Id
                                     select s.Debt).Sum();

                MessageBox.Show("Total debt to suppliers: " + totalDebt);
            }

        }
    }      
}
