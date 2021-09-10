using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());
            int number6 = Convert.ToInt32(Console.ReadLine());
            if (number1>number2&&number1>number3&&number1>number4&&number1>number5&&number1>number6)
            {
                Console.WriteLine("number1 en böyük ededdir");
            }
            else if (number2>number1&&number2>number3&&number2>number4&&number2>number5&&number2>number6)
            {
                Console.WriteLine("number2 en böyük ededdir");
            }
            else if (number3>number2&&number3>number1&&number3>number4&&number3>number5&&number3>number6)
            {
                Console.WriteLine("number3 en böyük ededdir");

            }
            else if (number4>number1&&number4>number2&&number4>number3&&number4>number5&&number4>number6)
            {
                Console.WriteLine("number4 en böyük ededdir");

            }
            else if (number5>number1&&number5>number2&&number5>number3&&number5>number4&&number5>number6)
            {
                Console.WriteLine("number5 en böyük ededdir");

            }
            else if (number6>number1&&number6>number5&&number6>number4&&number6>number3&&number6>number2&&number6>number1)
            {
                Console.WriteLine("number6 en böyük ededdir");

            }
        }
    }
}
