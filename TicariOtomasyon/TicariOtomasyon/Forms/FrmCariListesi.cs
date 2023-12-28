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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblcari
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYADI,
                               u.İL,
                               u.İLÇE,
                               u.BANKA,
                               u.STATÜ,
                               u.TELEFON,
                               u.MAIL,
                               u.ADRES

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            metot1();
            var degerler = from u in db.Tbliller
                           select new
                           {
                               u.id,
                               u.sehiradi,
                           };

            lookUpEdit1.Properties.DataSource = degerler.ToList();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tblcari t = new Tblcari();
            t.AD = txtCariAd.Text;
            t.SOYADI = txtCariSoyad.Text;
            t.TELEFON = txtCariTel.Text;
            t.İL = lookUpEdit1.Text;
            t.İLÇE = lookUpEdit2.Text;
            t.BANKA = txtBanka.Text;
            t.STATÜ = txtStatü.Text;
            t.MAIL = txtMail.Text;
            t.ADRES = txtAdres.Text;
            db.Tblcari.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            metot1();//Listele
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtCariId.Text);
            var deger = db.Tblcari.Find(id);
            db.Tblcari.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtCariId.Text);
            var deger = db.Tblcari.Find(id);
            deger.AD = txtCariAd.Text;
            deger.SOYADI = txtCariSoyad.Text;
            deger.TELEFON = txtCariTel.Text;
            deger.İL = lookUpEdit1.Text;
            deger.İLÇE = lookUpEdit2.Text;
            deger.BANKA = txtBanka.Text;
            deger.STATÜ = txtStatü.Text;
            deger.MAIL = txtMail.Text;
            deger.ADRES = txtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtCariId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtCariAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                txtCariSoyad.Text = gridView1.GetFocusedRowCellValue("SOYADI").ToString();
                txtCariTel.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                txtBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
                txtStatü.Text = gridView1.GetFocusedRowCellValue("STATÜ").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
                txtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");

            }
            

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from x in db.Tblilceler
                                                 select new
                                                 {
                                                   x.id,
                                                   x.ilceadi,
                                                   x.sehirid
                                                 }).Where(z=> z.sehirid == secilen).ToList();    
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtCariAd.Text = "";
            txtCariSoyad.Text = "";
            txtCariTel.Text = "";
            lookUpEdit1.Text = "";
            lookUpEdit2.Text = "";
            txtBanka.Text = "";
            txtStatü.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
        }
    }
}
