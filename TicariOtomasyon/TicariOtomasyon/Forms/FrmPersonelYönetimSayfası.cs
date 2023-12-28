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
    public partial class FrmPersonelYönetimSayfası : Form
    {
        public FrmPersonelYönetimSayfası()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void FrmPersonelYönetimSayfası_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.Tbldepartman
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD,

                                                 }).ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPersonelid.Text);
            var deger = db.Tblpersonel.Find(id);
            db.Tblpersonel.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            Tblpersonel t = new Tblpersonel();
            t.AD = txtPesonelAd.Text;
            t.SOYADI = txtPersonelSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.TELEFON = txtPersonelTelefon.Text;
            t.MAIL = txtPersonelMail.Text;
            db.Tblpersonel.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Kaydedildi.", "Bilgi");
        }
    }
}
