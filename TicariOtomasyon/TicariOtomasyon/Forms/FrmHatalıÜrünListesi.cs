using DevExpress.XtraPrinting.Export.Pdf;
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
    public partial class FrmHatalıÜrünListesi : Form
    {
        public FrmHatalıÜrünListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblhatalıurun
                           select new
                           {
                               u.HATALIÜRÜNID,
                               u.HATALIÜRÜNAD,
                               u.HATALIÜRÜNPERSONEL,
                               u.HATALIÜRÜNFİYAT,
                               u.HATALIÜRÜNACIKLAMA,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmHatalıÜrünListesi_Load(object sender, EventArgs e)
        {
            metot1();
            var degerler = from u in db.Tblpersonel
                           select new
                           {
                               u.ID,
                               PERSONEL = u.AD + " " + u.SOYADI,
                           };
            lookUpEdit1.Properties.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblhatalıurun t = new Tblhatalıurun();
            t.HATALIÜRÜNAD = txtHatalıurunad.Text;
            t.HATALIÜRÜNPERSONEL = lookUpEdit1.Text;
            t.HATALIÜRÜNFİYAT = decimal.Parse(txtSatisFiyat.Text);
            t.HATALIÜRÜNACIKLAMA = (txtAcıklama.Text);
            db.Tblhatalıurun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Hatalı Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtHatalıUrunId.Text);
            var deger = db.Tblhatalıurun.Find(id);
            db.Tblhatalıurun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Hatalı Ürün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtHatalıUrunId.Text);
            var deger = db.Tblhatalıurun.Find(id);
            deger.HATALIÜRÜNAD = txtHatalıurunad.Text;
            deger.HATALIÜRÜNPERSONEL = lookUpEdit1.Text;
            deger.HATALIÜRÜNACIKLAMA = (txtSatisFiyat.Text);
            deger.HATALIÜRÜNFİYAT = decimal.Parse(txtAcıklama.Text);
            db.SaveChanges();
            MessageBox.Show("Hatalı Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtHatalıUrunId.Text = gridView1.GetFocusedRowCellValue("HATALIÜRÜNID").ToString();
        }
    }
}
