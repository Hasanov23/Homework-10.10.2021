using System;

namespace task3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                Console.WriteLine("Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana");
                int number = Convert.ToInt32(Console.ReadLine());
                int lastdigit = number % 10;
                if (lastdigit == 7)
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
