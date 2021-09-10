using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<5)
            {
                Console.WriteLine("Ededin cüt ve ya tek olmasini yoxlayin!");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Eded cütdür");

                }
                else
                {
                    Console.WriteLine("Eded tekdir");
                }


            }
        }
    }
}
