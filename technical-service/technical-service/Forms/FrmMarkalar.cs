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
namespace technical_service.Forms
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var value = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = value.ToList();
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA).Distinct().Count().ToString();
            lblEnFazlaUrunuOlanMarka.Text = (from x in db.TBLURUN//foreach ile aynı mantık
                                            orderby x.STOK descending
                                            select x.MARKA).FirstOrDefault();
            lblEnYuksekFiyatliMarka.Text = (from x in db.TBLURUN//foreach ile aynı mantık
                                         orderby x.SATISFIYAT descending
                                         select x.MARKA).FirstOrDefault();
            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bosh", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 1);

            SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=DbTeknikServis;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA",connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            connect.Close();

            //chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 2);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 7);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 3);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Laptop", 7);

            SqlConnection connect2 = new SqlConnection(@"Data Source=.;Initial Catalog=DbTeknikServis;Integrated Security=True");
            connect2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT TBLKATEGORİ.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORİ ON TBLKATEGORİ.ID=TBLURUN.KATEGORI GROUP BY TBLKATEGORİ.AD", connect2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            connect2.Close();





        }
    }
}
