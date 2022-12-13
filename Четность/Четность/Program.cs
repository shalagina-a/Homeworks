using System;
namespace Parity
{
    class Program
    {
        static bool Parity(int m, int n)
        {
            return ((m % 2 == 0 && n % 2 != 0) || (n % 2 == 0 && m % 2 != 0));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m и n");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            bool result = Parity(m, n);
            Console.WriteLine("Только одно из чисел m и n четное - " + result);
            Console.ReadKey();
        }
    }
}
