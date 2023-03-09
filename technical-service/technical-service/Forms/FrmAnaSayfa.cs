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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            grdKritikSeviye.DataSource = (from x in db.TBLURUN
                                          select new
                                          {
                                              x.AD,
                                              x.STOK
                                          }).Where(x => x.STOK < 5).ToList();

            grdFihrist.DataSource = (from x in db.TBLCARI
                                     select new
                                     {
                                         x.AD,
                                         x.SOYAD,
                                         x.IL
                                     }).ToList();
            grdKategoriUrün.DataSource = db.UrunKategori().ToList();//prosedür cagrildi.

            for (int i = 1; i <= 10; i++)//Son 10 mesaj sıralandı konusu ve yazanın adı gosterildi.
            {
                string konu = db.TBLILETISIM.First(x => x.ID == i).KONU;
                string ad = db.TBLILETISIM.First(x => x.ID == i).ADSOYAD;
                DevExpress.XtraEditors.LabelControl lbl = (DevExpress.XtraEditors.LabelControl)this.Controls.Find("labelControl" + i, true)[0];
                lbl.Text = konu + "--" + ad;
            }
        }
    }
}
