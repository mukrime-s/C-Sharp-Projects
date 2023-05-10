using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace xoxGame
{
    public partial class loginScreen : Form
    {
        public static string userName;
        string outputFile;
        public loginScreen()
        {
            InitializeComponent();
            this.Controls.Add(rememberMeCheckBox);
            outputFile = "../../../user.txt";//dosyayı okumak icin olsuturldu.
            FileStream fileStream = new FileStream(outputFile, FileMode.OpenOrCreate, FileAccess.Read);
            //Bir sonraki çalıştırmada, kaydedilen ayarların sistem tarafından hatırlanması için
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string satir = reader.ReadLine();
                if (satir != "")
                {
                    txtUsername.Text = satir;
                }
                reader.Close();
            }

            fileStream.Close();
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LoadLoginCredentials();
            txtPassword.UseSystemPasswordChar = true;
            string lastUserName = Properties.Settings.Default.LastUserName;
            if (!string.IsNullOrEmpty(lastUserName))
            {
                txtUsername.Text = lastUserName;
                txtPassword.Focus();
            }
            else
            {
                txtUsername.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerScreen rs = new registerScreen();
            rs.Show();
            this.Hide();
        }
        private bool IsValidUser(string userName, string password)// kaydedilen kisinin girisi saglandi.
        {
            var doc = XDocument.Load("userTest.xml");
            var user = doc.Descendants("user")
                              .FirstOrDefault(u => u.Element("username").Value == userName
                                                  && u.Element("password").Value == password);
            return user != null;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("userTest.xml");

            XmlNode users = xDoc.SelectSingleNode("users");
            XmlNodeList userInfos = users.SelectNodes("userInformation");

            bool isValidUser = false;

            foreach (XmlNode info in userInfos)
            {
                if (txtUsername.Text == info.SelectSingleNode("Username").InnerText &&
                    txtPassword.Text == info.SelectSingleNode("Password").InnerText)
                {
                    isValidUser = true;
                    break;
                }
            }

            if (isValidUser)
            {
                settingScreen settingsScreen = new settingScreen();
                settingsScreen.Show();
                this.Hide();

                if (rememberMeCheckBox.Checked)
                {
                    SaveLoginCredentials(txtUsername.Text, txtPassword.Text);
                }

                using (StreamWriter sW = new StreamWriter(outputFile))
                {
                    sW.WriteLine(txtUsername.Text);
                }
            }
            else if ((txtUsername.Text == "user" || txtUsername.Text == "USER") &&
                    (txtPassword.Text == "user" || txtPassword.Text == "USER"))
            {
                userName = txtUsername.Text;
                settingScreen settingsScreen = new settingScreen();
                settingsScreen.Show();
                this.Hide();

                if (rememberMeCheckBox.Checked)
                {
                    SaveLoginCredentials(txtUsername.Text, txtPassword.Text);
                }

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine(txtUsername.Text);
                }
            }
            else if ((txtUsername.Text == "admin" || txtUsername.Text == "ADMIN") &&
                    (txtPassword.Text == "admin" || txtPassword.Text == "ADMIN"))
            {
                userName = txtUsername.Text;

                settingScreen settingsScreen = new settingScreen();
                settingsScreen.Show();
                this.Hide();

                if (rememberMeCheckBox.Checked)
                {
                    SaveLoginCredentials(txtUsername.Text, txtPassword.Text);
                }

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine(txtUsername.Text);
                }
            }
            else
            {
                lblError.Text = "Invalid username or password!";
            }
        }
        private void radioBtnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void SaveLoginCredentials(string username, string password)
        {
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

      
        private void LoadLoginCredentials()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                rememberMeCheckBox.Checked = true;
            }
            else
            {
                rememberMeCheckBox.Checked = false;
            }
        }
    }
}