using System;
namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение ε");
            int ε = int.Parse(Console.ReadLine());
            int n = 0;
            double a = 1;

            while (true)
            {

                if (Math.Abs(2 - a) < ε)
                    Console.WriteLine("{0}, {1}", n, a);
                    break;

                a = a + Math.Pow(0.5, n);
                n = n + 1;
            }
            Console.ReadKey();
        }
    }
}