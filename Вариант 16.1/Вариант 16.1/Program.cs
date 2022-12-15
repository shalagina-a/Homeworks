using System;
namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " фунтов = " + i * 453 + " г.");
            }
            Console.ReadKey();
        }
    }
}