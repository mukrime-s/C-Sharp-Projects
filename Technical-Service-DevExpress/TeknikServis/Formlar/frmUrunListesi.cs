using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class frmUrunListesi : Form
    {
        public frmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();//modeldeki yapılari tutan yapi
        private void frmUrunListesi_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN tu = new TBLURUN();
            tu.AD = txtUrunAd.Text;
            tu.MARKA = txtMarka.Text;
            tu.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
            tu.SATISFIYAT= decimal.Parse(txtSatisFiyati.Text);
            tu.STOK = short.Parse(txtStok.Text);
            tu.DURUM = false;
            db.TBLURUN.Add(tu);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedilmistir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btListele_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyati.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
        }
    }
}
