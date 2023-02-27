using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace technical_service
{
    public partial class mainContent : Form
    {
        public mainContent()
        {
            InitializeComponent();
        }

        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmUrunListesi fu = new Forms.FrmUrunListesi();
            fu.MdiParent = this;
            fu.Show();
        }

        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniUrun fu = new Forms.FrmYeniUrun();
            fu.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKategori fk = new Forms.FrmKategori();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniKategori fk = new Forms.FrmYeniKategori();
            fk.Show();
        }

        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmIstatistik fk = new Forms.FrmIstatistik();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnMarkaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMarkalar fk = new Forms.FrmMarkalar();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCariListesi fk = new Forms.FrmCariListesi();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnCariIlIstatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmCariIller fk = new Forms.FrmCariIller();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniCari fk = new Forms.FrmYeniCari();
            fk.Show();
        }
    }
}
