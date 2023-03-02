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

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartman fk = new Forms.FrmDepartman();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniDepartman fk = new Forms.FrmYeniDepartman();
            fk.Show();
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnDovizKurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKurBilgisi fk = new Forms.FrmKurBilgisi();
            fk.MdiParent = this;
            fk.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYoutube fk = new Forms.FrmYoutube();
            fk.MdiParent = this;
            fk.Show();
        }
    }
}
