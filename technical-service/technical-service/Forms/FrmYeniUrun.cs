using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace technical_service.Forms
{
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            FrmYeniUrun fyu = new FrmYeniUrun();
            //fyu.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities dts = new DbTeknikServisEntities();
            TBLURUN tu = new TBLURUN();
            tu.AD = txtUrunAdi.Text;
            tu.MARKA = txtMarka.Text;
            tu.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
            tu.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
            tu.STOK = short.Parse(txtStok.Text);
            tu.KATEGORI = byte.Parse(txtKategori.Text);
            dts.TBLURUN.Add(tu);
            dts.SaveChanges();
            MessageBox.Show("Ürün Kaydedilmiştir.");
        }


        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAdi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
