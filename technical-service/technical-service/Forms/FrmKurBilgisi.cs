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
    public partial class FrmKurBilgisi : Form
    {
        public FrmKurBilgisi()
        {
            InitializeComponent();
        }

        private void FrmKurBilgisi_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
        }
    }
}
