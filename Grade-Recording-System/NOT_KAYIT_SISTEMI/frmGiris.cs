using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOT_KAYIT_SISTEMI
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmOgrenciDetay föd = new frmOgrenciDetay();
            föd.numara = maskedTextBox1.Text;
            föd.Show();
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")//ogretmen icin 1111 default olarak olusturuldu.
            {
                frmOgretmenDetay frmogrtmn = new frmOgretmenDetay();
                frmogrtmn.Show(); 
            }

        }
    }
}
