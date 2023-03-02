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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN td = new TBLDEPARTMAN();
            if (txtDepartmanAdi.Text.Length <= 50 && txtDepartmanAdi.Text != "")
            {
                td.AD = txtDepartmanAdi.Text;
                db.TBLDEPARTMAN.Add(td);
                db.SaveChanges();
                MessageBox.Show("Departman Eklenmistir");
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz");
            }
        }
    }
}
