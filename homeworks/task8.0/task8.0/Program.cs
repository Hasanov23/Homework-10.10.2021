using System;

namespace task8._0
{
    class Program
    {
        static void Main(string[] args)
        { int number = Convert.ToInt32(Console.ReadLine());
            int Lastdigit = number % 10;
            switch (Lastdigit)
            {
            case 1:
            Console.WriteLine("Birinci gün");
            break;
            case 2:
            Console.WriteLine("Ikinci gün");
            break;
            case 3:
              
            Console.WriteLine("Ücüncü gün");
            break;
            case 4:
            Console.WriteLine("Dördüncü gün");
            break;
            case 5:
            Console.WriteLine("Beshinci gün");
            break;
            case 6:
            Console.WriteLine("Altinci gün");
            break;
            case 7:
            Console.WriteLine("Yeddinci gün");
            break;
                default:
                    Console.WriteLine("Shert ödenilmir");
                    break;
            }

        }
            
        }
    }

