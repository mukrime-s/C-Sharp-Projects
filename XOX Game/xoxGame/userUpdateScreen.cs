using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Linq;

namespace xoxGame
{
    public partial class userUpdateScreen : Form
    {
        public userUpdateScreen()
        {
            InitializeComponent();
        }
        /**
         * @brief Veri tabaninin kullanilmasi icin degiskenler olusturuldu.
         */
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel ap = new adminPanel();
            ap.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE userinfo Set (UserType,Username,Passwords,NameSurname,Mail) values (@UserType,@Username,@Password,@NameSurname,@Mail)";
            komut = new SqlCommand(sorgu, baglanti);
            if ((txtPassword.Text != "") && (txtNameSurname.Text != "") //tüm kullanıcı bilgilerini doldurması için
                && (txtMail.Text != ""))
            {

                baglanti.Open();
                da = new SqlDataAdapter("select count(*) from userinfo where id = " + txtId.Text + "", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                komut = new SqlCommand("update userinfo set UserType = '" + txtUserType.Text.ToString() + "'," +
                    "Passwords = '" + txtPassword.Text.ToString() + "',NameSurname = '" + txtNameSurname.Text.ToString() + "',Mail = '" + txtMail.Text.ToString() + "'where id =" + txtId.Text + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Saved");

            }
            else
            {
                label1.Text = "Error";
            }
        }
    }
}
