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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities dte = new DbTeknikServisEntities();

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var values = from k in dte.TBLURUN
                         select new
                         {
                             k.ID,
                             k.AD,
                         };
            gridControl1.DataSource = values.ToList();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = dte.TBLKATEGORİ.Find(id);
            dte.TBLKATEGORİ.Remove(value);
            dte.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ tk = new TBLKATEGORİ();
            tk.AD = txtAd.Text;
            dte.TBLKATEGORİ.Add(tk);
            dte.SaveChanges();
            MessageBox.Show("Kategori kaydedildi.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = from k in dte.TBLURUN
                         select new
                         {
                             k.ID,
                             k.AD,
                         };
            gridControl1.DataSource = values.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = dte.TBLKATEGORİ.Find(id);
            value.AD = txtAd.Text;
            dte.SaveChanges();
            MessageBox.Show("Kategori Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
