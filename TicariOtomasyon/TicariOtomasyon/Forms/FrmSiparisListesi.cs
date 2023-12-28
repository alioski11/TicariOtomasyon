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
    public partial class FrmSiparisListesi : Form
    {
        public FrmSiparisListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblsiparis
                           select new
                           {
                               u.SİPARİSİD,
                               u.SİPARİSAD,
                               u.SİPARİSALANPERSONEL,
                               u.SİPARİSACIKLAMA,
                               u.SİPARİSYAPIMTARİHİ,
                               u.SİPARİSFİYAT,
                               
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblsiparis t = new Tblsiparis();
            t.SİPARİSAD = txtSiparisAd.Text;
            t.SİPARİSALANPERSONEL = txtPersonel.Text;
            t.SİPARİSFİYAT = decimal.Parse(txtSiparisFiyatı.Text);
            t.SİPARİSACIKLAMA = richTextBox1.Text;
            t.SİPARİSYAPIMTARİHİ = DateTime.Parse(txtTarihi.Text);
            db.Tblsiparis.Add(t);
            db.SaveChanges();
            MessageBox.Show("Sipariş Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSİparisId.Text);
            var deger = db.Tblsiparis.Find(id);
            db.Tblsiparis.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Sipariş Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtSİparisId.Text);
            var deger = db.Tblsiparis.Find(id);
            deger.SİPARİSAD = txtSiparisAd.Text;
            deger.SİPARİSALANPERSONEL = txtPersonel.Text;
            deger.SİPARİSFİYAT = decimal.Parse(txtSiparisFiyatı.Text);
            deger.SİPARİSACIKLAMA = (richTextBox1.Text);
            deger.SİPARİSYAPIMTARİHİ = DateTime.Parse(txtTarihi.Text);
            db.SaveChanges();
            MessageBox.Show("Sipariş Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmSiparisListesi_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtSİparisId.Text = gridView1.GetFocusedRowCellValue("SİPARİSİD").ToString();
        }
    }
}
