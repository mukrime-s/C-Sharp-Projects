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

namespace NOT_KAYIT_SISTEMI
{
    public partial class frmOgrenciDetay : Form
    {
        public frmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOO;Initial Catalog=DbNotKayit;Integrated Security=True");
        //Data Source=MUKOO;Initial Catalog=DbNotKayit;Integrated Security=True
        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDERS WHERE OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text = dr[2].ToString() + "" + dr[3].ToString();
                lblSınav1.Text = dr[4].ToString();
                lblSınav2.Text = dr[5].ToString();
                lblOrtalama.Text = dr[6].ToString();
                lblDurum.Text = dr[7].ToString();
            }
            baglanti.Close();
        }
    }
}
