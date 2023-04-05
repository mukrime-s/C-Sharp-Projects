using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.HaftaOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSifrelemeDesifreleme_Click(object sender, EventArgs e)
        {
            string operationText = radiobtnSifreleme.Checked ? "Encryption" : "Decryption";
            string algorithmText = radiobtnCaesar.Checked ? "Caesar" : "Vigenère";
            string result = "";

            if (radiobtnCaesar.Checked)
            {
                if (radiobtnSifreleme.Checked)
                {
                    result = CaesarCipher.Encrypt(txtMetin.Text, tctOgrenciNo.Text);
                }
                else if (radiobtnDesifreleme.Checked)
                {
                    result = CaesarCipher.Decrypt(txtMetin.Text, tctOgrenciNo.Text);
                }
            }
            else if (radiobtnVigenere.Checked)
            {
                if (radiobtnSifreleme.Checked)
                {
                    result = VigenereCipher.Encrypt(txtMetin.Text, tctOgrenciNo.Text);
                }
                else if (radiobtnDesifreleme.Checked)
                {
                    result = VigenereCipher.Decrypt(txtMetin.Text, tctOgrenciNo.Text);
                }
            }

            int score = TestFunctions.testFuncApp3(tctOgrenciNo.Text, txtMetin.Text, algorithmText, operationText.ToLower(), result, "", "", "", "");

            lblSkor.Text = $"Score: {score}";

            lblSifrelenmisDesifrelenmisMetin.Text = $"{operationText} with {algorithmText} Cipher: {result}";
        }

        private void tctOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//ögrenci numarasi alanına sadece sayi girilmesi saglandi.
        }
    }

    public static class CaesarCipher
    {
        public static string Encrypt(string message, string key)
        {
            int shift = 0;
            bool success = int.TryParse(key, out shift);
            if (!success || shift == 0)
            {
                shift = 1;
            }

            StringBuilder result = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    // Harfse, ASCII değerini alarak belirli bir sayı (anahtar) kadar kaydirir.
                    char shifted = (char)((((c + shift) - 'A') % 26) + 'A');
                    result.Append(shifted);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string message, string key)
        {
            int shift;
            if (!int.TryParse(key, out shift) || shift == 0)
            {
                throw new ArgumentException("Key must be a non-zero number");
            }

            StringBuilder result = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    // Harfse, ASCII değerini alarak belirli bir sayı (anahtar) kadar kaydırma işlemi yapılır.
                    char shifted = (char)((((c - shift) - 'A' + 26) % 26) + 'A');
                    result.Append(shifted);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }


    public static class VigenereCipher
    {
        public static string Encrypt(string message, string key)
        {
            StringBuilder result = new StringBuilder();

            int keyIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                char k = key[keyIndex];

                if (char.IsLetter(c))
                {
                    // Harfse, ASCII değerini alarak belirli bir sayı (anahtar) kadar kaydirir.
                    char shifted = (char)((((c + k) - 2 * 'A') % 26) + 'A');
                    result.Append(shifted);

                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string message, string key)
        {
            StringBuilder result = new StringBuilder();

            int keyIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                char k = key[keyIndex];

                if (char.IsLetter(c))
                {
                    // Harfse, ASCII değerini alarak belirli bir sayı (anahtar) kadar kaydırma işlemi yapılır.
                    char shifted = (char)((((c - k) + 26) % 26) + 'A');
                    result.Append(shifted);

                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }

    

}

