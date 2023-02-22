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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities tse = new DbTeknikServisEntities();
        void mymethod()
        {
            var values = from u in tse.TBLURUN
                         select new
                         {
                             u.ID,
                             u.AD,
                             u.MARKA,
                             KATEGORI=u.TBLKATEGORİ.AD,
                             u.STOK,
                             u.ALISFIYAT,
                             u.SATISFIYAT
                         };
            gridControl1.DataSource = values.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //var values = tse.TBLURUN.ToList();
            mymethod();
            
            lookUpEdit1.Properties.DataSource = tse.TBLKATEGORİ.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN tu = new TBLURUN();
            tu.AD = txtUrunAd.Text;
            tu.MARKA = txtMarka.Text;
            tu.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
            tu.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
            tu.STOK = short.Parse(txtStok.Text);
            tu.DURUM = false;
            tu.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());

            tse.TBLURUN.Add(tu);//verileri ekler.
            tse.SaveChanges();
            MessageBox.Show("Ürün Eklenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            mymethod();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)//tıklanan ürünün özelliklerini yan tarafta görebilmek icin olusturuldu.
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyati.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = tse.TBLURUN.Find(id);
            tse.TBLURUN.Remove(value);
            tse.SaveChanges();
            MessageBox.Show("Ürün Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = tse.TBLURUN.Find(id);
            value.AD = txtUrunAd.Text;
            value.STOK = short.Parse(txtStok.Text);
            value.MARKA = txtMarka.Text;
            value.ALISFIYAT = decimal.Parse(txtAlisFiyati.Text);
            value.SATISFIYAT = decimal.Parse(txtSatisFiyati.Text);
            value.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());

            tse.SaveChanges();
            MessageBox.Show("Ürün Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
