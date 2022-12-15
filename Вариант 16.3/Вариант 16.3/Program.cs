using System;
namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            int x = int.Parse(Console.ReadLine()); 
            

            Console.WriteLine("Введите значение m"); 
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение k"); 
            double k = double.Parse(Console.ReadLine());

            int n = 1;
            double y = x / 12 + 1;
            double m1 = m * y;
            
            while (true)
            {
                if ((m1 - m) > k)
                {
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    n = n + 1;
                    m1 = m1 * y;
                }
            }
            Console.ReadKey();
        }
    }
}