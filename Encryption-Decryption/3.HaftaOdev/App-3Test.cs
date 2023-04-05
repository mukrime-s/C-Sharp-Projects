using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HaftaOdev
{
    public class TestFunctions
    {
        public static int testFuncApp3(string studentNumber, string inputText, string algorithm, string encDecSelect, string outputText, string encryptedTextwithCaesar, string encryptedTextwithVigenere, string decryptedTextwithCaesar, string decryptedTextwithVigenere)
        {
            int score = 0;
            if (algorithm == "Caesar")
            {
                if (encDecSelect == "encrypt")
                {
                    string caesarResult = CaesarCipher.Encrypt(inputText, "7");
                    if (caesarResult == encryptedTextwithCaesar)
                    {
                        score += 25;
                    }

                    string decryptedCaesarResult = CaesarCipher.Decrypt(caesarResult, "7");
                    if (decryptedCaesarResult == inputText)
                    {
                        score += 25;
                    }
                }
                else if (encDecSelect == "decrypt")
                {
                    string caesarResult = CaesarCipher.Decrypt(inputText, "7");
                    if (caesarResult == decryptedTextwithCaesar)
                    {
                        score += 25;
                    }
                    string encryptedCaesarResult = CaesarCipher.Encrypt(caesarResult, "7");
                    if (encryptedCaesarResult == inputText)
                    {
                        score += 25;
                    }
                }
            }
            if (algorithm == "Vigenere")
            {
                if (encDecSelect == "encrypt")
                {
                    string vigenereResult = VigenereCipher.Encrypt(inputText, "esoguce");
                    if (vigenereResult == encryptedTextwithVigenere)
                    {
                        score += 25;
                    }

                    string decryptedVigenereResult = VigenereCipher.Decrypt(vigenereResult, "esoguce");
                    if (decryptedVigenereResult == inputText)
                    {
                        score += 25;
                    }
                }
                else if (encDecSelect == "decrypt")
                {
                    string vigenereResult = VigenereCipher.Decrypt(inputText, "esoguce");
                    if (vigenereResult == decryptedTextwithVigenere)
                    {
                        score += 25;
                    }

                    string encryptedVigenereResult = VigenereCipher.Encrypt(vigenereResult, "esoguce");
                    if (encryptedVigenereResult == inputText)
                    {
                        score += 25;
                    }
                }
            }

            return score;
        }

    }
}
