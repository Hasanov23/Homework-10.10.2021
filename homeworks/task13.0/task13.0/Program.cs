using System;

namespace task13._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmish 7 reqemli eded polindromdursa o zaman onun daxilnde nece dene 0 reqemi oldugunu tap ?
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>=1000000&&number<=9999999)
            {
                int digit1 =  number % 10;
                int digit2 = (number % 100 ) / 10;
                int digit3 = (number % 1000) / 100;
                int digit4 = (number %10000)/1000;
                int digit5 = (number %100000)/10000;
                int digit6 = (number %1000000)/100000;
                int digit7 = (number %10000000)/1000000;

                int reverseNumber = ((((((digit1 * 10 + digit2) * 10 + digit3) * 10 + digit4) * 10 + digit5) * 10 + digit6) * 10 + digit7);
                Console.WriteLine(reverseNumber);
                if (number==reverseNumber)
                {
                    int count = 0;
                    int[] digits = { digit1, digit2, digit3, digit4, digit5, digit6, digit7 };
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i]==0)
                        {
                            count++;


                        }
                        
                    }
                    if (count==0)
                    {
                        Console.WriteLine("Ededin daxilinde 0 mövcud deyil");

                    }
                    else
                    {
                        Console.WriteLine("Bu ededde {0} dene 0 var", count);
                        
                    }
                }
            }
        
        }
    }
}
