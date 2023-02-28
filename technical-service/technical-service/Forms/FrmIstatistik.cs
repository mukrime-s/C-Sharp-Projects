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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblToplamKategori.Text = db.TBLKATEGORİ.Count().ToString();
            lblToplamStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            lblEnFazlaStokluUrun.Text = (from x in db.TBLURUN//foreach ile aynı mantık
                                         orderby x.STOK descending
                                         select x.AD).FirstOrDefault();
            lblEnAzStokluUrun.Text = (from x in db.TBLURUN
                                         orderby x.STOK ascending
                                         select x.AD).FirstOrDefault();
            lblEnYuksekFiyatlıUrun.Text = (from x in db.TBLURUN
                                      orderby x.SATISFIYAT descending
                                      select x.AD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN
                                           orderby x.SATISFIYAT ascending
                                           select x.AD).FirstOrDefault();
            lblBeyazEsyaStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            lblKucukEvAletleriSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            lblBilgisayarSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            lblToplamMarkaSayisi.Text = (from x in db.TBLURUN
                                         select x.MARKA).Distinct().Count().ToString();

        }
    }
}
