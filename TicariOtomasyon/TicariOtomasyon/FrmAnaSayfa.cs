using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.Forms;

namespace TicariOtomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        public FrmAnaSayfa(FrmAnasayfa fr)
        {
            this.fr = fr;
        }

        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmÜrünListesi fr = new Forms.FrmÜrünListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKategoriListesics fr = new Forms.FrmKategoriListesics();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnUrunIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmÜrünİstatistik fr = new Forms.FrmÜrünİstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMarkalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMarkalar fr = new Forms.FrmMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCariListesi fr = new Forms.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariİlİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCariİlİstatistik fr = new Forms.FrmCariİlİstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Forms.FrmDepartmanListesi fr = new Forms.FrmDepartmanListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnPersonelİslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPersonelListesi fr = new Forms.FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKurlar fr = new Forms.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void Btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnNotislemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNotlar fr = new Forms.FrmNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnHatalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmHatalıÜrünListesi fr = new Forms.FrmHatalıÜrünListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnSatısIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSatısListesi fr = new Forms.FrmSatısListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnSiparisİslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmSiparisListesi fr = new Forms.FrmSiparisListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmQROluştur fr = new Forms.FrmQROluştur();
            fr.Show();
        }

        private void BtnYeniFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniFatura fr = new Forms.FrmYeniFatura();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaturaKalem fr = new Forms.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaDetaySorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmFaturaSorgulama fr = new Forms.FrmFaturaSorgulama();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmRaporlar fr = new Forms.FrmRaporlar();
            fr.Show();
        }

        Forms.FrmAnasayfa fr;

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                Forms.FrmAnasayfa fr = new Forms.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }
            
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Forms.FrmAnasayfa fr = new Forms.FrmAnasayfa();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmE_Fatura fr = new Forms.FrmE_Fatura();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Forms.FrmBugünİslemler fr = new Forms.FrmBugünİslemler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("outlook.exe");
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("outlook.exe");
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDugunİslemleri fr = new Forms.FrmDugunİslemleri();
            fr.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmGiderler fr = new Forms.FrmGiderler();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}

