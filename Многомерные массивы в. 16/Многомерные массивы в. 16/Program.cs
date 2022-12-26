using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n в пределах от 5 до 20");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение m в пределах от 5 до 20");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n,m];

            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(100);
                }
            }

            PrintArray(a);

            Console.WriteLine(DescendingOrder(a));

            Console.WriteLine(SumOfEvenElements(a));

            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j],2} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static string DescendingOrder(int[,] array)
        {
            bool flag = true;
            int a = 0;
            int b = 0;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 1; j < array.GetLength(1); j++)
                    if (array[i, j] > array[i, j - 1])
                    {
                        flag = false;
                        a = array[i, j - 1];
                        b = array[i, j];
                        //break;
                    }
            }

            if (flag = true)
                return ("Строки массива упорядочены по убыванию");
            else 
                return ($"Строки массива не упорядочены по убыванию: {a} {b}");
        }

        static string SumOfEvenElements(int[,] array)
        {
            string s = "";
            for (var i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (var j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] % 2 == 0)
                        sum += array[i, j];
                s += ($"{i} - {sum}; ");
            }
            return(s);
        }
    }
}