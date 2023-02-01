using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialization_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(deneme.users), new XmlRootAttribute("users"));

                using (FileStream fileStream = new FileStream("userinfo.xml", FileMode.Open))//xml dosyasi acildi.
                {
                    deneme.users newInvoice = (deneme.users)serializer.Deserialize(fileStream);
                    //Console.WriteLine("ID: " + newInvoice.userInformation.id);
                    //Console.WriteLine("UserType: " + newInvoice.userInformation.UserType);
                    //Console.WriteLine("Username: " + newInvoice.userInformation.Username);
                    //Console.WriteLine("Password: " + newInvoice.userInformation.Password);
                    //Console.WriteLine("NameSurname: " + newInvoice.userInformation.NameSurname);
                    //Console.WriteLine("PhoneNumber: " + newInvoice.userInformation.PhoneNumber);
                    //Console.WriteLine("Address: " + newInvoice.userInformation.Address);
                    //Console.WriteLine("City: " + newInvoice.userInformation.City);
                    //Console.WriteLine("Country: " + newInvoice.userInformation.Country);
                    //Console.WriteLine("Mail: " + newInvoice.userInformation.Mail);
                    //Console.WriteLine("userInformation: " + newInvoice.userInformation);

                    //Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDB;Integrated Security=True"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("INSERT INTO Users (UserType, Username, Password, NameSurname, PhoneNumber, Address, City, Country, Mail) " +
                            "VALUES (@UserType, @Username, @Password, @NameSurname, @PhoneNumber, @Address, @City, @Country, @Mail)", connection);

                        command.Parameters.AddWithValue("@UserType", newInvoice.userInformation.UserType);
                        command.Parameters.AddWithValue("@Username", newInvoice.userInformation.Username);
                        command.Parameters.AddWithValue("@Password", newInvoice.userInformation.Password);
                        command.Parameters.AddWithValue("@NameSurname", newInvoice.userInformation.NameSurname);
                        command.Parameters.AddWithValue("@PhoneNumber", newInvoice.userInformation.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", newInvoice.userInformation.Address);
                        command.Parameters.AddWithValue("@City", newInvoice.userInformation.City);
                        command.Parameters.AddWithValue("@Country", newInvoice.userInformation.Country);
                        command.Parameters.AddWithValue("@Mail", newInvoice.userInformation);

                        command.ExecuteNonQuery();

                        MessageBox.Show("User added successfully!");
                        MessageBox.Show("Serialization Completed");
                    }

                }

            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine("Xml file is not found:" + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc.Message);
            }
        }
    }
}
