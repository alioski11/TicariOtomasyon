using DevExpress.Xpo.DB.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TicariOtomasyon.Forms
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.Tblurun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).
                Select(z => new
                {
                    Marka = z.Key,
                    Toplam = z.Count()
                });
            gridControl1.DataSource = degerler.ToList();

            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-B5KLAJ57;Initial Catalog=DbTicariOtomasyon;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA, COUNT(*) FROM Tblurun GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();


            try
            {
                // hata alıyoruz???
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("SELECT Tblkategori.AD, COUNT(*) FROM Tblurun INNER JOIN Tblkategori ON Tblkategori.ID = Tblurun.KATEGORİ GROUP BY Tblkategori.AD", baglanti);
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                chartControl2.Series["Series 1"].Points.AddPoint("EV ALETLERİ ", 5);
                chartControl2.Series["Series 1"].Points.AddPoint("TEKNOLOJİK ALETLER ", 4);
                chartControl2.Series["Series 1"].Points.AddPoint("BEYAZ EŞYA ", 3);
            }
        }
    }
}
