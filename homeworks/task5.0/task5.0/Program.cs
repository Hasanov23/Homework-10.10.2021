using System;

namespace task5._0
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 0;
          while (i < 5)
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                if (number1 >= 10 && number1 <= 99)
                {
                    int FirstDigit = number1 % 10;
                    int LastDigit = number1 / 10;
                    int sum = FirstDigit + LastDigit;
                    if (sum %2==0)
                    {
                        int multiply = FirstDigit * LastDigit;
                        Console.WriteLine("Daxil edilen ededin reqemlerinin hasili:" + multiply);
                    }
                else
                    {
                        Console.WriteLine("Daxil edilen ededin reqemlerinin cemi cüt deyil");
                    }

                }
                else
                {
                    Console.WriteLine("Shert ödenilmir");
                }

            }
            
        }
    }
}
