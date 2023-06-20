using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Encryprtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();

            var ciphertext = Encryption(text);

            Console.WriteLine("Зашифрованный текст: " + ciphertext);
            Console.WriteLine("Расшифрованный текст: " + Decryption(ciphertext));

            Console.ReadKey();
        }

        static string Encryption(string text)
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