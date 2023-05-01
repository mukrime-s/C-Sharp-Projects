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
    public partial class userAddScreen : Form
    {
        public userAddScreen()
        {
            InitializeComponent();
        }
        string file = @"../../../counter.txt";
        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel ap = new adminPanel();
            ap.Show();
            this.Hide();
        }

        private void userAddScreen_Load(object sender, EventArgs e)
        {
            string file = @"../../../counter.txt";
            if (File.Exists(file) == true)
            {
                string temp;
                int count = Convert.ToInt32(File.ReadAllText(file));
                count++;
                temp = count.ToString();
                File.WriteAllText(file, temp);
            }
            else
            {
                FileInfo fi = new FileInfo(file);
                StreamWriter sw = new StreamWriter(file);
                string temp;
                int count = 0;
                temp = count.ToString();
                sw.Close();
                File.WriteAllText(file, temp);
            }

            string counter = File.ReadAllText(file);
            txtId.Text = counter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string counter = File.ReadAllText(file);

            if ((txtUsername.Text != "") && (txtPassword.Text != "") && (txtNameSurname.Text != "") //tüm kullanıcı bilgilerini doldurması için
                 && (txtMail.Text != ""))
            {

                XDocument x = XDocument.Load(@"../../userinfo.xml");
                x.Element("users").Add(
                    new XElement("userInformation",
                    new XElement("id", counter),
                    new XElement("UserType", txtUserType.Text),
                    new XElement("Username", txtUsername.Text),
                    new XElement("Password", txtPassword),
                    new XElement("NameSurname", txtNameSurname.Text),
                    new XElement("Mail", txtMail.Text)));
                x.Save(@"../../../userinfo.xml");
                label1.Text = "Saved";
            }
            else
            {
                label1.Text = "Error";
                string temp;
                int count = Convert.ToInt32(counter);
                count--;
                temp = count.ToString();
                File.WriteAllText(file, temp);
            }
        }
    }
}
