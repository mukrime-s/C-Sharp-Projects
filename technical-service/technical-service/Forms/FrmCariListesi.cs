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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
