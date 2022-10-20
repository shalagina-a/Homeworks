using System;
namespace Metod
{
    class Program
    {
        static double Formule(int a, int b)
        {
            return Math.Sqrt(a + Math.Log(1 + Math.Sqrt(b)));

        }
        static void Main(string[] args)
        {
            double x1 = Formule(2, 3);
            double x2 = Formule(3, 7);
            double x3 = Formule(5, 5);
            double result = Math.Round(x1 + x2 + x3, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}