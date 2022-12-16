using System;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());
            int c = 1;

            for (int i = 1; i != n; i++)
            {
                c = c * 10;
            }

            Console.WriteLine("Все простые n-значные числа:");

            for (int i = c; i != c*10; i++)
            {
                bool flag = true;
                for (int j = 2; j != i-1; j++)
                {
                    if (i % j == 0)
                        flag = false;
                }

                if (flag)
                    Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}