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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities dts = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ tu = new TBLKATEGORİ();
            tu.AD = txtKategoriAdi.Text;
            dts.TBLKATEGORİ.Add(tu);
            dts.SaveChanges();
            MessageBox.Show("Ürün Kaydedilmiştir.");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {

        }
    }
}
