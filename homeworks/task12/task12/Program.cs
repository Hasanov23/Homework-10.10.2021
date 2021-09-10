using System;

namespace task12
{
    class Program
    {
        
    static void Main(string[] args)
            
            {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>=100000&&number<=999999)
            {
                int number1 = (number + 8000000 ) * 10 + 8;
                Console.WriteLine(number1);
                int firstFourDigit = number1 / 10000;
                int lastFourDigit = number1 % 10000;
                int reverseNumber = lastFourDigit *10000 + firstFourDigit;
                Console.WriteLine(reverseNumber);
                int digit1 = reverseNumber % 10;
                int digit2 = (reverseNumber % 100 - digit1) / 10;
                int digit3 = (reverseNumber % 1000 - digit1 / 100) / 100;
                int digit4 = (reverseNumber % 10000 - digit2 / 1000) / 1000;
                int digit5 = (reverseNumber % 100000 - digit3 / 10000) / 10000;
                int digit6 = (reverseNumber % 1000000 - digit3 / 100000) / 100000;
                int digit7 = (reverseNumber % 10000000 - digit4 / 1000000) / 1000000;
                int digit8 = reverseNumber  / 10000000;

             
                int result = (((((((digit8 * 10 + 0) * 10 + digit6) * 10 + 0) * 10 + digit4) * 10 + 0) * 10 + digit2) * 10 + 0);
                Console.WriteLine(result);
            }

            
        }
    }
}
