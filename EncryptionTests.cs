using NUnit.Framework;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EncryptionTests.UnitTests
{
    [TestFixture]
    public class EncryptionTests
    {
        [Test]
        public void EncryptionTest()
        {
            // Arrange:
            string message1 = "stierlitz";
            string message2 = "A little bee";
            string message3 = "secret information";


            //Act:
            string ciphertext1 = Encryption(message1);
            string ciphertext2 = Encryption(message2);
            string ciphertext3 = Encryption(message3);


            string decrypted_text1 = Decryption(ciphertext1);
            string decrypted_text2 = Decryption(ciphertext2);
            string decrypted_text3 = Decryption(ciphertext3);

            //Assert:
            Assert.That(decrypted_text1, Is.EqualTo("stierlitz"));
            Assert.That(decrypted_text2, Is.EqualTo("alitlebe"));
            Assert.That(decrypted_text3, Is.EqualTo("secretinformation"));

        }

        private string Encryption(string text)
        {
            string new_text = new String(text.ToLower().Where(Char.IsLetter).ToArray());
            string ciphertext = "";

            for (int i = 0; i < new_text.Length - 1; i++)
            {

                if (new_text[i] != new_text[i + 1])
                {
                    ciphertext += new_text[i];
                }

            }
            ciphertext += new_text[new_text.Length - 1];

            Random rnd = new Random();
            string[] symb = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            int n = rnd.Next(ciphertext.Length, ciphertext.Length * 3);
            for (var i = 0; i < n; i++)
            {
                int num = rnd.Next(0, ciphertext.Length);
                string letter = symb[rnd.Next(26)];

                ciphertext = ciphertext.Insert(num, letter + letter);
            }

            return ciphertext;
        }

        static string Decryption(string text)
        {
            List<char> letters = new List<char>();
            var decrypted_text = "";


            for (int i = 0; i < text.Length; i++)
            {
                letters.Add(text[i]);
            }

            bool flag = true;

            while (flag == true)
            {
                for (int i = 0; i < letters.Count - 1; i++)
                {
                    if (letters[i] == letters[i + 1])
                    {
                        letters[i] = '1';
                        letters[i + 1] = '1';
                    }
                }

                flag = letters.Remove('1');
            }

            for (var i = 0; i < letters.Count; i++)
            {
                decrypted_text += letters[i];
            }

            return decrypted_text;
        }
    }
}