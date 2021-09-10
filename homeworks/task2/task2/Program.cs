using System;

namespace task2
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            
            Console.WriteLine("2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart. Eks halda  bolunmur sozunu cap et");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1%number2==0)
            {
                Console.WriteLine(number1/number2);
            }
            else
            {
                Console.WriteLine("Bölünmür");
            }
        }
    }
}

