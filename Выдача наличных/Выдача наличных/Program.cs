using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите денежную сумму, кратную 100 и не превышающую 50000:");
            Console.WriteLine("(Enter - отказ от ввода)");
            int sum = int.Parse(Console.ReadLine());
            if ((sum > 50000) || (sum % 100 != 0))
            {
                do
                {
                    Console.WriteLine("Введенная денежная сумма не соответствует условию. Повторите ввод.");
                    sum = int.Parse(Console.ReadLine());
                } while ((sum > 50000) || (sum % 100 != 0));
            }

            sum = sum / 100;
            int count = 0;
            for (int bill_100 = 0; bill_100 <= sum; bill_100++)
            {
                for (int bill_200 = 0; bill_200 <= sum; bill_200++)
                {
                    for (int bill_500 = 0; bill_500 <= sum; bill_500++)
                    {
                        for (int bill_2000 = 0; bill_2000 <= sum; bill_2000++)
                        {
                            for (int bill_5000 = 0; bill_5000 <= sum; bill_5000++)
                            {
                                if ((bill_5000 * 50 + bill_2000 * 20 + bill_500 * 5 + bill_200 * 2 + bill_100 * 1) == sum)
                                    count += 1;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Количество способов, которыми банкомат может набрать данную сумму: ");
            Console.WriteLine(count);

            Console.ReadKey();

        }
    }
}