using System;

namespace Leet
{
    class Program
    {
        static string Leet(string inputStr)
        {
            inputStr = inputStr.ToUpper();
            inputStr = inputStr.Replace("A", "4");
            inputStr = inputStr.Replace("B", "8");
            inputStr = inputStr.Replace("C", "(");
            inputStr = inputStr.Replace("D", "|)");
            inputStr = inputStr.Replace("E", "3");
            inputStr = inputStr.Replace("F", "|=");
            inputStr = inputStr.Replace("G", "6");
            inputStr = inputStr.Replace("H", "|-|");
            inputStr = inputStr.Replace("I", "!");
            inputStr = inputStr.Replace("J", ")");
            inputStr = inputStr.Replace("K", "|<");
            inputStr = inputStr.Replace("L", "1");
            inputStr = inputStr.Replace("M", "|\\/|");       
            inputStr = inputStr.Replace("N", "|\\|");
            inputStr = inputStr.Replace("O", "0");
            inputStr = inputStr.Replace("P", "|>");
            inputStr = inputStr.Replace("Q", "9");
            inputStr = inputStr.Replace("R", "|2");
            inputStr = inputStr.Replace("S", "5");
            inputStr = inputStr.Replace("T", "7");
            inputStr = inputStr.Replace("U", "|_|");
            inputStr = inputStr.Replace("V", "\\/");
            inputStr = inputStr.Replace("W", "\\/\\/");
            inputStr = inputStr.Replace("X", "|-|");
            inputStr = inputStr.Replace("Y", "><");
            inputStr = inputStr.Replace("Z", "2");

            return inputStr;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputStr = Console.ReadLine();
            Console.WriteLine(Leet(inputStr));
            Console.ReadKey();
        }
    }
}