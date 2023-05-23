﻿using System;
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

namespace xoxGame
{
    public partial class userAddScreen : Form
    {
        public userAddScreen()
        {
            InitializeComponent();
        }
        string file = @"../../../counter.txt";
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

        private void userAddScreen_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=userinfo;Integrated Security=SSPI");
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

                string sorgu = "INSERT INTO userinfo (UserType,Username,Passwords,NameSurname,Mail) values (@UserType,@Username,@Password,@NameSurname,@Mail)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@UserType", txtUserType.Text);
                komut.Parameters.AddWithValue("@Username", txtUsername.Text);
                komut.Parameters.AddWithValue("@Passwords", txtPassword.Text);
                komut.Parameters.AddWithValue("@NameSurname", txtNameSurname.Text);
                komut.Parameters.AddWithValue("@Mail", txtMail.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Saved");
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
