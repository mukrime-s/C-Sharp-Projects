using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class deneme
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class users
        {

            private usersUserInformation userInformationField;

            /// <remarks/>
            public usersUserInformation userInformation
            {
                get
                {
                    return this.userInformationField;
                }
                set
                {
                    this.userInformationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class usersUserInformation
        {
            private byte idField;
            private string userTypeField;
            private string usernameField;
            private string passwordField;
            private string nameSurnameField;
            private ulong phoneNumberField;
            private string addressField;
            private string cityField;
            private string countryField;
            private string mailField;

            /// <remarks/>
            public byte id
            {
                get
                {return this.idField;}
                set
                {this.idField = value;}
            }

            /// <remarks/>
            public string UserType
            {
                get
                {return this.userTypeField;}
                set
                {this.userTypeField = value;}
            }

            /// <remarks/>
            public string Username
            {
                get
                {return this.usernameField;}
                set
                {this.usernameField = value;}
            }

            /// <remarks/>
            public string Password
            {
                get
                {return this.passwordField;}
                set
                {this.passwordField = value;}
            }

            /// <remarks/>
            public string NameSurname
            {
                get
                {return this.nameSurnameField;}
                set
                {this.nameSurnameField = value;}
            }

            /// <remarks/>
            public ulong PhoneNumber
            {
                get
                {return this.phoneNumberField;}
                set
                {this.phoneNumberField = value;}
            }

            /// <remarks/>
            public string Address
            {
                get
                {return this.addressField; }
                set
                {this.addressField = value;}
            }

            /// <remarks/>
            public string City
            {
                get
                {return this.cityField;}
                set
                {this.cityField = value;}
            }

            /// <remarks/>
            public string Country
            {
                get
                {return this.countryField;}
                set
                {this.countryField = value; }
            }

            /// <remarks/>
            public string Mail
            {
                get
                {return this.mailField;}
                set
                {this.mailField = value;}
            }
        }
    }
}
