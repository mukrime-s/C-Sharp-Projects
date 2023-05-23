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
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace xoxGame
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti;
        public static SqlCommand komut;
        public static SqlDataAdapter da;
        void listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=userinfo;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM userinfo", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            userUpdateScreen uu = new userUpdateScreen();
            uu.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userAddScreen ua = new userAddScreen();
            ua.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to permanently delete the user?", "Delete Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM userinfo WHERE id=@id";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("User permanently deleted");
                settingScreen sc = new settingScreen();
                sc.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }

}
