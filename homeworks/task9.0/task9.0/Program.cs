using System;

namespace task9._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int Lastdigit = number & 10;
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Yanvar");
                        break;
                    case 2:
                        Console.WriteLine("Fevral");
                        break;
                    case 3:
                        Console.WriteLine("Mart");
                        break;
                    case 4:
                        Console.WriteLine("Aprel");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("Iyun");
                        break;
                    case 7:
                        Console.WriteLine("Iyul");
                        break;
                    case 8:
                        Console.WriteLine("Avqust");
                        break;
                    case 9:
                        Console.WriteLine("Sentyabr");
                        break;
                    case 10:
                        Console.WriteLine("Oktyabr");
                        break;
                    case 11:
                        Console.WriteLine("Noyabr");
                        break;
                    case 12:
                        Console.WriteLine("Dekabr");
                        break;

                    default:

                        Console.WriteLine("Shert ödenilmir");
                        break;
                }

            }
            
        }
    }
}
