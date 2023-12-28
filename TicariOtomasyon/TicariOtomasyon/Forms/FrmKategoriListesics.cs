using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmKategoriListesics : Form
    {
        public FrmKategoriListesics()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmKategoriListesics_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.Tblkategori
                           select new
                           {
                               k.ID,
                               k.AD

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && txtKategoriAd.Text.Length <= 30)
            {
                Tblkategori t = new Tblkategori();
                t.AD = txtKategoriAd.Text;
                db.Tblkategori.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Fazla Olamaz");
            }    
        }
        

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.Tblkategori
                           select new
                           {
                               k.ID,
                               k.AD

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deger = db.Tblkategori.Find(id);
            db.Tblkategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi.");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtKategoriAd.Text = "";
            txtKategoriId.Text = "";

        }
    }
}
