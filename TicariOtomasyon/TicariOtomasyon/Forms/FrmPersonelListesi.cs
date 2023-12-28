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
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        public void metot1()
        {
            var degerler = from u in db.Tblpersonel
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYADI,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();


        }

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnVerileriYenile_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void BtnPersonelYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPersonelYönetimSayfası fr = new Forms.FrmPersonelYönetimSayfası();
            fr.Show();
        }
    }
}
