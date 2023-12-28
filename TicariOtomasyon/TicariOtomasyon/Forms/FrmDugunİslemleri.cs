using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmDugunİslemleri : Form
    {
        public FrmDugunİslemleri()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tbldugun
                           select new
                           {
                               u.DUGUNID,
                               u.DUGUNTÜRÜ,
                               u.DUGUNSAHİBİ,
                               u.DUGUNSAHİBİTELEFON,                           
                               u.DUGUNTARİHİ,
                               u.DUGUNFİYAT,
                               u.PERSONEL,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmDugunİslemleri_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.Tblpersonel
                           select new
                           {
                               u.ID,
                               PERSONEL = u.AD + " " + u.SOYADI,
                           };

            lookUpEditPersonel.Properties.DataSource = degerler.ToList();
            metot1();
            labelControl29.Text = db.Tbldugun.Sum(x => x.DUGUNFİYAT).ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDugunId.Text);
            var deger = db.Tbldugun.Find(id);
            db.Tbldugun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Düğün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Tbldugun t = new Tbldugun();
            t.DUGUNSAHİBİ = txtDugunSahibi.Text;
            t.DUGUNTÜRÜ = txtDugunTuru.Text;
            t.DUGUNFİYAT = decimal.Parse(txtDugunSatısFiyatı.Text);
            t.PERSONEL = lookUpEditPersonel.Text;
            t.DUGUNTARİHİ = DateTime.Parse(txtDugunTarihi.Text);
            t.DUGUNSAHİBİTELEFON = txtDugunSahibiTelefon.Text;
            db.Tbldugun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Düğün Satışı Başarıyla Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDugunId.Text);
            var deger = db.Tbldugun.Find(id);
            deger.DUGUNSAHİBİ = txtDugunSahibi.Text;
            deger.DUGUNTÜRÜ = txtDugunTuru.Text;
            deger.DUGUNFİYAT = decimal.Parse(txtDugunSatısFiyatı.Text);
            deger.PERSONEL = lookUpEditPersonel.Text;
            deger.DUGUNTARİHİ = DateTime.Parse(txtDugunTarihi.Text);
            deger.DUGUNSAHİBİTELEFON = txtDugunSahibiTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Satılan Düğün  Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            metot1();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtDugunId.Text = "";
            txtDugunTuru.Text = "";
            txtDugunSahibi.Text = "";
            txtDugunTarihi.Text = "";
            txtDugunSatısFiyatı.Text = "";
            txtDugunSahibiTelefon.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDugunId.Text = gridView1.GetFocusedRowCellValue("DUGUNID").ToString();
            txtDugunSahibi.Text = gridView1.GetFocusedRowCellValue("DUGUNSAHİBİ").ToString();
            txtDugunSatısFiyatı.Text = gridView1.GetFocusedRowCellValue("DUGUNFİYAT").ToString();
            txtDugunTarihi.Text = gridView1.GetFocusedRowCellValue("DUGUNTARİHİ").ToString();
            txtDugunTuru.Text = gridView1.GetFocusedRowCellValue("DUGUNTÜRÜ").ToString();
            txtDugunSahibiTelefon.Text = gridView1.GetFocusedRowCellValue("DUGUNSAHİBİTELEFON").ToString();
        }
    }
}
