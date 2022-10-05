class Program
{
    static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Андрей Белый");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Один");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Окна запотели.");
        Console.WriteLine("На дворе луна.");
        Console.WriteLine("И стоишь без цели");
        Console.WriteLine("У окна.");


        Console.WriteLine("Ветер.Никнет, споря,");
        Console.WriteLine("Ряд седых берез.");
        Console.WriteLine("Много было горя...");
        Console.WriteLine("Много слез...");

        Console.WriteLine("И встает невольно");
        Console.WriteLine("Скучный ряд годин.");
        Console.WriteLine("Сердцу больно, больно...");
        Console.WriteLine("Я один.");


        Console.ResetColor();
        Console.ReadKey();
    }
}