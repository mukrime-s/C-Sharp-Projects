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
using System.Xml.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace xoxGame
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        void listele()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"../../../userinfo.xml", new XmlReaderSettings());
            ds.ReadXml(xmlfile);

            ds.Tables[0].Columns.Remove(ds.Tables[0].Columns["Password"]);

            dataGridView1.DataSource = ds.Tables[0];

            xmlfile.Close();
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
            string file = @"../../../userinfo.xml";
            XDocument x = XDocument.Load(file);
            XElement rootElement = x.Root;
            foreach (XElement Users in rootElement.Elements())
            {
                if (Users.Element("id").Value == txtDelete.Text) //idye göre silme işlemi yapıldı.
                {
                    Users.Remove();
                }
            }
            x.Save(file);
        }
    }

}
