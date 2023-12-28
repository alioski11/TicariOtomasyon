using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraPrinting.Export.Pdf;
using DevExpress.XtraRichEdit.UI;
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
    public partial class FrmSatısListesi : Form
    {
        public FrmSatısListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            var degerler = from u in db.Tblsatılanurun
                           select new
                           {
                               u.SATILANURUNID,
                               u.SATILANURUNAD,
                               u.SATILANURUNCARİ,
                               u.SATILANURUNPERSONELİ,
                               u.SATILANURUNADET,
                               u.SATILANURUNFİYAT,
                               u.SATILANURUNTARİH,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmSatısListesi_Load(object sender, EventArgs e)
        {
            var degerler2 = from x in db.Tblcari
                            select new
                            {
                                x.AD,
                                CARİ = x.AD + " " + x.SOYADI,
                            };

            lookUpEditCari.Properties.DataSource = degerler2.ToList();
            
            var degerler = from u in db.Tblpersonel
                           select new
                           {
                               u.ID,
                               PERSONEL = u.AD + " " + u.SOYADI,
                           };

            lookUpEditPersonel.Properties.DataSource = degerler.ToList();
           

            metot1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblsatılanurun t = new Tblsatılanurun();
            t.SATILANURUNAD= txtSatılanUrun.Text;
            t.SATILANURUNPERSONELİ = lookUpEditPersonel.Text;
            t.SATILANURUNFİYAT = decimal.Parse(txtSatısFiyatı.Text);
            t.SATILANURUNCARİ = lookUpEditCari.Text;
            t.SATILANURUNADET = Byte.Parse(txtAdet.Text);
            t.SATILANURUNTARİH = DateTime.Parse(txtTarihi.Text);
            db.Tblsatılanurun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Satış Başarıyla Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSatılanUrunId.Text);
            var deger = db.Tblsatılanurun.Find(id);
            db.Tblsatılanurun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSatılanUrunId.Text);
            var deger = db.Tblsatılanurun.Find(id);
            deger.SATILANURUNAD = txtSatılanUrun.Text;
            deger.SATILANURUNPERSONELİ = lookUpEditPersonel.Text;
            deger.SATILANURUNFİYAT = decimal.Parse(txtSatısFiyatı.Text);
            deger.SATILANURUNCARİ = lookUpEditCari.Text;
            deger.SATILANURUNADET =  Byte.Parse(txtAdet.Text);
            deger.SATILANURUNTARİH = DateTime.Parse(txtTarihi.Text);
            db.SaveChanges();
            MessageBox.Show("Satılan Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtSatılanUrunId.Text = gridView1.GetFocusedRowCellValue("SATILANURUNID").ToString();
            txtSatılanUrun.Text = gridView1.GetFocusedRowCellValue("SATILANURUNAD").ToString();
            txtSatısFiyatı.Text = gridView1.GetFocusedRowCellValue("SATILANURUNFİYAT").ToString();
            txtTarihi.Text = gridView1.GetFocusedRowCellValue("SATILANURUNTARİH").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("SATILANURUNADET").ToString();
           
        }
    }
}
