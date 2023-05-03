using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxGame
{
    public partial class settingScreen : Form
    {
        public settingScreen()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form1 gameScreen = new Form1();
            gameScreen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel ap = new adminPanel();
            ap.Show();
            this.Hide();
        }

        private void settingScreen_Load(object sender, EventArgs e)
        {
            if (loginScreen.userName=="admin")
            {
                btnAdminPanel.Visible = true;
            }
            else
                btnAdminPanel.Visible = false;
        }
    }
}
