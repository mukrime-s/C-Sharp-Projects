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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 35);
            chartControl1.Series["Series 1"].Points.AddPoint("Eskişehir", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).
                Select(z => new { Il = z.Key, Toplam = z.Count() }).ToList();
            connect.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT IL,COUNT(*) FROM TBLCARI GROUP BY IL", connect);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
                }
                connect.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Hata olustu: " + exc.Message);
            }

        }
    }
}
