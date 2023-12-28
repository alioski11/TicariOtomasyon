using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class FrmYeniFatura : Form
    {
        public FrmYeniFatura()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblfaturabilgi
                           select new
                           {
                               u.ID,
                               u.SERİ,
                               u.SIRANO,
                               u.VERGİDAİRE,
                               u.SAAT,
                               u.TARİH,
                               CARİ =u.Tblcari.AD + u.Tblcari.SOYADI,
                               PERSONEL = u.Tblpersonel.AD + u.Tblpersonel.SOYADI ,

                           };
            gridControl1.DataSource = degerler.ToList();
            

        }
        private void FrmYeniFatura_Load(object sender, EventArgs e)
        {
            lookUpEditcari.Properties.DataSource = (from x in db.Tblcari
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYADI,

                                                 }).ToList();
            lookUpEditpersonel.Properties.DataSource = (from x in db.Tblpersonel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYADI,

                                                 }).ToList();
            metot1();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblfaturabilgi t = new Tblfaturabilgi();
            t.SERİ = txtseri.Text;
            t.SIRANO = txtsırano.Text;
            t.TARİH = Convert.ToDateTime(txttarih.Text);
            t.SAAT = txtsaat.Text;
            t.VERGİDAİRE = txtvergidaire.Text;
            t.CARİ = int.Parse(lookUpEditcari.EditValue.ToString());
            t.PERSONEL = lookUpEditpersonel.EditValue.ToString();
            db.Tblfaturabilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFaturaId.Text);
            var deger = db.Tblfaturabilgi.Find(id);
            deger.SERİ = txtseri.Text;
            deger.SIRANO = txtsırano.Text;
            deger.TARİH = Convert.ToDateTime(txttarih.Text);
            deger.SAAT = txtsaat.Text;
            deger.VERGİDAİRE = txtvergidaire.Text;
            deger.CARİ = int.Parse(lookUpEditcari.EditValue.ToString());
            deger.PERSONEL = lookUpEditpersonel.EditValue.ToString();
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtFaturaId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopUp fr = new FrmFaturaKalemPopUp();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
