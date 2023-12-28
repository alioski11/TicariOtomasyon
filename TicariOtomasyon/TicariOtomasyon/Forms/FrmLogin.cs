using DevExpress.XtraEditors;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sorgu = from  x in db.Tbladmin where x.KUULANICIADI ==
                        textEdit1.Text & x.SIFRE == textEdit2.Text select x;
            if (sorgu.Any())
            {
                FrmAnaSayfa frm = new FrmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş!!");  
            }
        }

        private void BtnKullancıEkle_Click(object sender, EventArgs e)
        {
            Forms.FrmKullanıcıEkle fr = new Forms.FrmKullanıcıEkle();
            fr.Show();
        }
    }
}
