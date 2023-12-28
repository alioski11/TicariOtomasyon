using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmÜrünListesi : Form
    {
        public FrmÜrünListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblurun
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               u.STOK,
                               KARTEGORİ = u.Tblkategori.AD,
                               u.ALISFİYATI,
                               u.SATISFİYATI

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmÜrünListesi_Load(object sender, EventArgs e)
        {
            // Listeleme Tolist Silme Remove Ekleme Add

            //var degerler = db.Tblurun.ToList();
            var degerler = from u in db.Tblkategori
                           select new
                           {
                               u.ID,
                               u.AD,
                           };

            lookUpEdit1.Properties.DataSource = degerler.ToList();
            metot1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblurun t = new Tblurun();
            t.AD = txtUrun.Text;
            t.ALISFİYATI = decimal.Parse(txtAlısFiyat.Text);
            t.SATISFİYATI = decimal.Parse(txtSatısFıyat.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.MARKA = txtMarka.Text;
            t.DURUM = false;
            t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Tblurun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
            lookUpEdit1.Properties.DataSource = db.Tblkategori.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrun.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtAlısFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFİYATI").ToString();
                txtSatısFıyat.Text = gridView1.GetFocusedRowCellValue("SATISFİYATI").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.Tblurun.Find(id);
            db.Tblurun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.Tblurun.Find(id);
            deger.AD = txtUrun.Text;
            deger.STOK = short.Parse(txtStok.Text);
            deger.MARKA = txtMarka.Text;
            deger.ALISFİYATI = decimal.Parse(txtAlısFiyat.Text);
            deger.SATISFİYATI = decimal.Parse(txtSatısFıyat.Text);
            deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = "";
            txtUrun.Text = "";
            txtAlısFiyat.Text = "";
            txtSatısFıyat.Text = "";
            txtStok.Text = "";
            txtMarka.Text = "";
        }
    }

}
