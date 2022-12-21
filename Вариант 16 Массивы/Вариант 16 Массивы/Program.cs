using System;
using System.Xml.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n, n<=20");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите дейсвительное число λ");
            int λ = int.Parse(Console.ReadLine());

            double[] m = new double[n];

            for (int i = 1; i != n; i++)
            {
                m[i] = (Math.Pow(λ, i) / Factorial(i)) * Math.Exp(-λ);
            }

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            PrintArray(m);

            m = SumElements(m);
            PrintArray(m);

            SumAbsDifference(m);

            double[] m1 = new double[n];
            m1 = m;
            DifferenceArray(m1, λ);
            PrintArray(m1);

            Console.ReadKey();
        }

        static void PrintArray(double[] array)
        {
            string s = "";
            foreach (var i in array)
                s += ($"{i} ");
            Console.WriteLine(s);
        }

        static double[] SumElements(double[] array)
        {
            double s = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                s += array[i];
                array[i] = s;
            }
            return(array);
        }

        static void SumAbsDifference(double[] array)
        {
            double s = 0;
            for (int i = 1; i < array.Length; i++)
            {
                s += Math.Abs(array[i]- array[i-1]);
            }
            Console.WriteLine(s);
        }

        static double[] DifferenceArray(double[] array, double a)
        {
            double[] array1 = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - a;
            }
            return (array1); ;
        }
    }
}