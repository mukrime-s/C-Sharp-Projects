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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities(); 
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var values = from d in db.TBLDEPARTMAN
                         select new
                         {
                             d.ID,
                             d.AD,
                             d.ACIKLAMA,
                         };
            gridControl1.DataSource = values.ToList();
            lblToplamDepartman.Text = db.TBLDEPARTMAN.Count().ToString();
            lblToplamPersonel.Text = db.TBLPERSONEL.Count().ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN td = new TBLDEPARTMAN();
            if(txtAd.Text.Length<=50 && txtAd.Text != "")
            {
                td.AD = txtAd.Text;
                td.ACIKLAMA = txtAciklama.Text;
                db.TBLDEPARTMAN.Add(td);
                db.SaveChanges();
                MessageBox.Show("Departman Eklenmistir");
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(values);
            db.SaveChanges();
            MessageBox.Show("Departman Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = from d in db.TBLDEPARTMAN
                         select new
                         {
                             d.ID,
                             d.AD,
                             d.ACIKLAMA,
                         };
            gridControl1.DataSource = values.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var value = db.TBLDEPARTMAN.Find(id);
            value.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
