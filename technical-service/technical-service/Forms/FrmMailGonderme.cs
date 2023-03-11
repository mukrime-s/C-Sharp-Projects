using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace technical_service.Forms
{
    public partial class FrmMailGonderme : Form
    {
        public FrmMailGonderme()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)//mail gonderilme islemleri yapildi.
        {
            MailMessage mail = new MailMessage();
            string gonderici = "gonderici";
            string sifre = "sifreniz";
            string alici = txtAlici.Text;
            string konu = txtKonu.Text;
            string acıklama = txtAciklama.Text;
            mail.From = new MailAddress(gonderici);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(gonderici, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("mail gönderilmiştir.");
        }
    }
}
