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
    public partial class FrmKullanıcıEkle : Form
    {
        public FrmKullanıcıEkle()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tbladmin t = new Tbladmin();
            t.KUULANICIADI = txtkullanıcıadı.Text;
            t.SIFRE = txtSifre.Text;
            db.Tbladmin.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarıyla Eklendi.", "Bilgi");
        }
    }
}
