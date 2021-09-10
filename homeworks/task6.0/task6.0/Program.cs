using System;

namespace task6._0
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            while (i<5)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 100 && number <= 999)
                {
                    int digit1 = number / 100;
                    int digit2 = (number % 100 - number % 10) / 10;
                    int digit3 = number % 10;

                    int sum = digit1 + digit3;
                    if (sum == digit2)
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
