using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Сторона квадрата: ");
        int a = int.Parse(Console.ReadLine());
        int s = a * a;

        Console.Write("Площадь: " + s);
        int p = 4 * a;
        Console.Write("Периметр: " + p);

        Console.ReadKey();
    }
}