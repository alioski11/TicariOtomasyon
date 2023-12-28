using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmÜrünİstatistik : Form
    {
        public FrmÜrünİstatistik()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void FrmÜrünİstatistik_Load(object sender, EventArgs e)//LİNQ SORGULARI(ürün istatikleri)
        {
            
            labelControl9.Text = db.Tblurun.Count().ToString();
            labelControl5.Text = db.Tblkategori.Count().ToString();
            labelControl7.Text = db.Tblurun.Sum(x => x.STOK).ToString();
            labelControl11.Text = (from x in db.Tblurun orderby x.STOK descending select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.Tblurun orderby x.STOK ascending select x.AD).FirstOrDefault();
            labelControl15.Text = db.maksurunkategorisi().FirstOrDefault();
            labelControl19.Text = (from x in db.Tblurun orderby x.SATISFİYATI descending select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.Tblurun orderby x.SATISFİYATI ascending select x.AD).FirstOrDefault();
            labelControl29.Text = db.Tblhatalıurun.Sum(x => x.HATALIÜRÜNFİYAT).ToString();
            labelControl27.Text = db.Tblhatalıurun.Count(x => x.HATALIÜRÜNID == 3).ToString();
            labelControl21.Text = (from x in db.Tblurun select x.KATEGORİ).Distinct().Count().ToString();
            labelControl23.Text = (from x in db.Tblurun select x.KATEGORİ).Max().ToString();

        }
    }
}
