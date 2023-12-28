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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblgider
                           select new
                           {
                               u.GIDERID,
                               u.GIDERACIKLAMA,
                               u.TARIH,
                               u.TUTAR
                           };
            gridControl1.DataSource = degerler.ToList();
        }




        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            metot1();
            labelControl29.Text = db.Tblgider.Sum(x => x.TUTAR).ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Tblgider t = new Tblgider();
            t.GIDERACIKLAMA = txtAcıklama.Text;
            t.TARIH = DateTime.Parse(txtGiderTarihi.Text);
            t.TUTAR = decimal.Parse(txtGiderFiyatı.Text);
            db.Tblgider.Add(t);
            db.SaveChanges();
            MessageBox.Show("Gider Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGiderId.Text);
            var deger = db.Tblgider.Find(id);
            deger.GIDERACIKLAMA = txtAcıklama.Text;
            deger.TARIH =DateTime.Parse (txtGiderTarihi.Text);
            deger.TUTAR = decimal.Parse(txtGiderFiyatı.Text);
            db.SaveChanges();
            MessageBox.Show("Gider Kaydı Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGiderId.Text);
            var deger = db.Tblgider.Find(id);
            db.Tblgider.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Gider Kaydı Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtGiderId.Text = "";
            txtAcıklama.Text = "";
            txtGiderTarihi.Text = "";
            txtGiderFiyatı.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtGiderId.Text = gridView1.GetFocusedRowCellValue("GIDERID").ToString();
            txtAcıklama.Text = gridView1.GetFocusedRowCellValue("GIDERACIKLAMA").ToString();
            txtGiderTarihi.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txtGiderFiyatı.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
        }
    }
}

