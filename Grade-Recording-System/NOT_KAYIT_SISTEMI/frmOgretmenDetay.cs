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
using System.Security.Cryptography;

namespace NOT_KAYIT_SISTEMI
{
    public partial class frmOgretmenDetay : Form
    {
        public frmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MUKOO;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void frmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1, @P2, @P3)",baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Sisteme Eklenmistir.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);//otomatik doldurma komutu.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string durum;
            double ortalama, s1, s2;
            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            ortalama = (s1 + s2) / 2;
            lblOrtalama.Text = ortalama.ToString();
            if (ortalama >= 59)
            {
                durum = "true";
            }
            else
                durum = "false";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLDERS SET OGRS1=@P1,OGRS2=@P2,ORTALAMA=@P3,DURUM=@P4 WHERE OGRNUMARA=@S6",baglanti);
            komut.Parameters.AddWithValue("@P1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@P4", durum);
            komut.Parameters.AddWithValue("@P5", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Notları Güncellenmistir.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);//otomatik doldurma komutu.

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
    }
}
