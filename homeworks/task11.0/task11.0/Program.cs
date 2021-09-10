using System;

namespace task11._0
{
    class Program
    {
        static void Main(string[] args)
        {
       //     Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
       //o zaman
       //    bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
       // Neticenin ustune ortaya dushen 2 reqemini gel
            int number=Convert.ToInt32(Console.ReadLine());
            if (number>=100000 && number<=999999)
            {
                int number1 = number / 1000;
                int number2 = number % 1000;
                int sum1=0;
                int sum2=0;
                while (number1!=0)
                {
                    sum1 += number1 % 10;
                    number1 /= 10;

                } while (number2!=0)
                {
                    sum2 += number2 % 10;
                    number2 /= 10;
                    
                }
                if (sum1==sum2)
                {
                    int number3 = number /10000;
                    int number4 = number % 100;
                    int number5 = number / 100 % 100;
                    int number6 = number3 * 100 +number4;
                    int result = number6 + number5;
                    Console.WriteLine(result);
                }

            }
        }
    }
}
