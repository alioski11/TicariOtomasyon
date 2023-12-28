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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public void metot1()
        {
            gridControl1.DataSource = db.Tblnotlarım.Where(x => x.OKUNDUBİLGİ == false).ToList();
            gridControl2.DataSource = db.Tblnotlarım.Where(y => y.OKUNDUBİLGİ == true).ToList();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tblnotlarım t = new Tblnotlarım();
            t.BASLIK = txtBaslık.Text;
            t.İÇERİK = richTextBox1.Text;
            t.TARİH = Convert.ToDateTime(txtTarih.Text);
            t.OKUNDUBİLGİ = false;
            db.Tblnotlarım.Add(t);
            db.SaveChanges();
            MessageBox.Show("NOT BAŞARIYLA KAYDEDİLDİ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {

                int id = int.Parse(txtNotID.Text);
                var deger = db.Tblnotlarım.Find(id);
                deger.OKUNDUBİLGİ = true;
                db.SaveChanges();
                MessageBox.Show("Okundu Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNotID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtNotID.Text);
            var deger = db.Tblnotlarım.Find(id);
            db.Tblnotlarım.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNotID.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
