using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение x:");

            int x = int.Parse(Console.ReadLine());
            int x1 = (int)(Math.Sqrt(x + 1) + Math.Sqrt(x - 1));
            int x2 = (int)(Math.Sqrt(x));
            int y = x1 / x2;

            Console.WriteLine("Значение y: " + y);

            Console.ReadKey();

        }

    }
}