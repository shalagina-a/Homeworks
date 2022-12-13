using System;
namespace S
{
    class Program
    {
        public static string Reverse(string input)

        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            string myString = "микросхема";
            string kos = myString.Substring(2, 1) + myString.Substring(4, 2);
            string kosmos = kos + kos.Replace("к", "м");

            string smeh = myString.Substring(5, 1) + Reverse(myString.Substring(6, 3));

            Console.WriteLine(kosmos);
            Console.WriteLine(smeh);
            Console.ReadKey();
        }
    }
}
