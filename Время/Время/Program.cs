using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество секунд:");
            int n = int.Parse(Console.ReadLine());
            int h = n/3600;
            int m = (n - h * 3600) / 60;
            int s = n - h * 3600 - m * 60;


            Console.WriteLine(h + " часов");
            Console.WriteLine(m + " минут");
            Console.WriteLine(s + " секунд");

            Console.ReadKey();

        }
        
    }
}