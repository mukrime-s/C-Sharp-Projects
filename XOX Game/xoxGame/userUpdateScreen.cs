using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Security.Cryptography;

namespace xoxGame
{
    public partial class userUpdateScreen : Form
    {
        public userUpdateScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel ap = new adminPanel();
            ap.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"../../../userinfo.xml");
            XElement update = x.Element("users").Elements("userInformation").FirstOrDefault(a => a.Element("id").Value.Trim() == txtId.Text);
            if ((txtPassword.Text != "") && (txtNameSurname.Text != "") //tüm kullanıcı bilgilerini doldurması için
                && (txtMail.Text != ""))
            {
                if (update != null)
                {
                    update.SetElementValue("UserType", txtUserType.Text);
                    update.SetElementValue("Password", txtPassword.Text);
                    update.SetElementValue("NameSurname", txtNameSurname.Text);
                    update.SetElementValue("Mail", txtMail.Text);
                    x.Save(@"../../../userinfo.xml");
                }
                label1.Text = "Saved";

            }
            else
            {
                label1.Text = "Error";
            }
        }
    }
}
