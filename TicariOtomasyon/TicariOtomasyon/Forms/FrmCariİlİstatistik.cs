using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TicariOtomasyon.Forms
{
    public partial class FrmCariİlİstatistik : Form
    {
        public FrmCariİlİstatistik()
        {
            InitializeComponent();
        }


        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void FrmCariİlİstatistik_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Tblcari.OrderBy(x => x.İL).
                GroupBy(y => y.İL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

            try
            {

                SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-B5KLAJ57;Initial Catalog=DbTicariOtomasyon;Integrated Security=True");

                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT,İL COUNT(*) FROM Tblcari GROUP BY İL", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                chartControl1.Series["Series 1"].Points.AddPoint("BURSA ", 1);
                chartControl1.Series["Series 1"].Points.AddPoint("İSTANBUL ", 1);
            }
        }
    }
}
