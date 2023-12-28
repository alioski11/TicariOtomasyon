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
    public partial class FrmDepartmanYönetimSayfası : Form
    {
        public FrmDepartmanYönetimSayfası()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbldepartman t = new Tbldepartman();
            t.AD = txtDepartmanAd.Text;
            t.ACIKLAMA = richTextBox1.Text;
            db.Tbldepartman.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Departman Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtDepartmanId.Text);
            var deger = db.Tbldepartman.Find(id);
            db.Tbldepartman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtDepartmanId.Text);
            var deger = db.Tbldepartman.Find(id);
            deger.AD = txtDepartmanAd.Text;
            deger.ACIKLAMA = richTextBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
