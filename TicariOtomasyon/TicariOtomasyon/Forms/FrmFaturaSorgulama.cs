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
    public partial class FrmFaturaSorgulama : Form
    {
        public FrmFaturaSorgulama()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void BtnAra_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textEdit1.Text);

                var degerler = (from u in db.Tblfaturadetay
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.BIRIMFIYAT,
                                    u.TOPLAMTUTAR,
                                    u.FATURAID

                                }).Where(x => x.FATURAID == id);

                gridControl1.DataSource = degerler.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Fatura ID Kısmını Boş Bırakmayınız.");
            }
           

        }
    }
}
