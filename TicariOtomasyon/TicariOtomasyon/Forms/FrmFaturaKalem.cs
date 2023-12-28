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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblfaturadetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.BIRIMFIYAT,
                               u.TOPLAMTUTAR,
                               u.FATURAID
                               
                           };
            gridControl1.DataSource = degerler.ToList();


        }
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblfaturadetay t = new Tblfaturadetay();
            t.URUN = txturun.Text;
            t.ADET = short.Parse(txtadet.Text);
            t.BIRIMFIYAT = decimal.Parse(txtfiyat.Text);
            t.TOPLAMTUTAR = decimal.Parse(txttoplamtutar.Text);
            t.FATURAID = int.Parse(txtfaturaid.Text);
            db.Tblfaturadetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Kalem Girişi Sisteme Kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFaturaDetayId.Text);
            var deger = db.Tblfaturadetay.Find(id);
            deger.URUN = txturun.Text;
            deger.ADET = short.Parse(txtadet.Text);
            deger.BIRIMFIYAT = decimal.Parse(txtfiyat.Text);
            deger.TOPLAMTUTAR = decimal.Parse(txttoplamtutar.Text);
            deger.FATURAID = int.Parse(txtfaturaid.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
