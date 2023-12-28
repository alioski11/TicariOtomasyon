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
    public partial class FrmBugünİslemler : Form
    {
        public FrmBugünİslemler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmBugünİslemler_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            var deger = (from x in db.Tblnotlarım.OrderBy(y => y.ID)
                         where (x.TARİH == bugun)
                         select new { x.BASLIK, x.İÇERİK, });
            gridControl1.DataSource = deger.ToList();
        }
    }
}
