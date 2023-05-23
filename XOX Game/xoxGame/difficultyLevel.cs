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
    public partial class difficultyLevel : Form
    {
        public difficultyLevel()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            mediumLevelGame mg = new mediumLevelGame();
            mg.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            hardLevelGame hg = new hardLevelGame();
            hg.Show();
            this.Hide();
        }
    }
}
