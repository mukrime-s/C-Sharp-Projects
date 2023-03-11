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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == txtKullaniciAdi.Text && x.SIFRE == txtSifre.Text select x;
            if (sorgu.Any())
            {
                mainContent mc = new mainContent();
                mc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı ya da şifre hatalı");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
