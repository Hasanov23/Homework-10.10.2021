using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {   int i = 0;
            while (i<5)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 100 && number <= 999)
                {
                    int digit1 = number / 100;
                    int digit2 = (number % 100 - number % 10) / 10;
                    int digit3 = number % 10;
                    if (digit1 + digit2 + digit3 == digit1 * digit1)
                    {
                        Console.WriteLine("Beli");
                    }

                
                else
                {
                    Console.WriteLine("Xeyr");
                }
                }

            }


        }
    }
}
