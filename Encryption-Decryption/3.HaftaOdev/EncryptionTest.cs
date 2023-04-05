using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HaftaOdev
{
    public class EncryptionTest
    {
        public static void TestEncryption()
        {
            // Test values
            string plainText = "MERHABA DUNYALI NASILSIN";
            string key = "secret";

            // Caesar Cipher tests
            string caesarEncrypted = CaesarCipher.Encrypt(plainText, "7");
            string caesarDecrypted = CaesarCipher.Decrypt(caesarEncrypted, "7");

            Console.WriteLine("Caesar Cipher Tests:");
            Console.WriteLine("Plaintext: " + plainText);
            Console.WriteLine("Key: 7");
            Console.WriteLine("Encrypted Text: " + caesarEncrypted);
            Console.WriteLine("Decrypted Text: " + caesarDecrypted);
            Console.WriteLine();

            // Vigenere Cipher tests
            string vigenereEncrypted = VigenereCipher.Encrypt(plainText, key);
            string vigenereDecrypted = VigenereCipher.Decrypt(vigenereEncrypted, key);

            Console.WriteLine("Vigenere Cipher Tests:");
            Console.WriteLine("Plaintext: " + plainText);
            Console.WriteLine("Key: " + key);
            Console.WriteLine("Encrypted Text: " + vigenereEncrypted);
            Console.WriteLine("Decrypted Text: " + vigenereDecrypted);
            Console.WriteLine();
        }
    }
}
