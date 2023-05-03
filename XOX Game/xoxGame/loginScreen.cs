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

namespace xoxGame
{
    public partial class loginScreen : Form
    {
        public static string userName;
        public loginScreen()
        {
            InitializeComponent();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void Btn_log_in_Click(object sender, EventArgs e)
        {
            string ad = txtUsername.Text;
            string parola = txtPassword.Text;

            if (ad == "admin" && parola == "admin")
            {
                userName = txtUsername.Text;
                settingScreen setting = new settingScreen();
                setting.Show();
                this.Hide();
            }
            if (ad == "user" && parola == "user")
            {
                userName = txtUsername.Text;
                settingScreen setting = new settingScreen();
                setting.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password!";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
