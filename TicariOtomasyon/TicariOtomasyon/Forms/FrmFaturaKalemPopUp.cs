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
    public partial class FrmFaturaKalemPopUp : Form
    {
        public FrmFaturaKalemPopUp()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        public int id;
        private void FrmFaturaKalemPopUp_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Tblfaturadetay.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.Tblfaturabilgi.Where(x => x.ID == id).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "FATURAKALEMLERİ1.Pdf";
            gridControl1.ExportToPdf (path);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = "FATURA1.Pdf";
            gridControl2.ExportToPdf(path);
        }
    }
}
