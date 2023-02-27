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
    public partial class FrmYeniCari : Form
    {
        public FrmYeniCari()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities DB = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.IL = txtIl.Text;
            t.ILCE = txtIlce.Text;
            MessageBox.Show("Yeni Cari Kaydedilmiştir.");
        }
    }
}
