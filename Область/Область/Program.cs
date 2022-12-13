using System;
namespace Area
{
    class Program
    {
        static bool Area(double x, double y)
        {
            return (-1 <= x && x <= 1.5 && -0.5 <= y && y <= 2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x и y");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool result = Area(x, y);
            Console.WriteLine("Точка с координатами x и y принадлежит к данной области - " + result);
            Console.ReadKey();
        }
    }
}