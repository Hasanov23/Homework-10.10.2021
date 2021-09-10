using System;

namespace task4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana");
            int i = 0;
            while (i<5)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 99)
                {
                    int firstDigit = number / 10;
                    int lastDigit = number % 10;
                    if (firstDigit == lastDigit)
                    {
                        Console.WriteLine("Beli");
                    }
                    else
                    {
                        Console.WriteLine("Xeyr");
                    }

                }
                else
                {
                    Console.WriteLine("Eded yanlishdir");

                }
            }

        }
    }
}
