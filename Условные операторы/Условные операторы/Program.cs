using System;
namespace If
{
    class Program
    {
        static int FunctionResult(int x)
        {
            if (x < -4)
                return 46;
            else if ((x >= -4) && (x <= 2))
                return 3 * x * x - 2;
            else
                return 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            int x = int.Parse(Console.ReadLine());
            int result = FunctionResult(x);
            Console.WriteLine("Результат функции f(x) - " + result);
            Console.ReadKey();
        }
    }
}