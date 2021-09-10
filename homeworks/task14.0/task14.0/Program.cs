using System;

namespace task14._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //        14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler(bu o demekdirki 1, 2, 3, 4, 5, 6, 7 reqemlide ola biler)
            //Bu ededin evvelin 1 reqemini artir.
            int myNum = Convert.ToInt32(Console.ReadLine());
            if (myNum>0&&myNum<99999999)
            {
                if (myNum>0&&myNum<=9)
                {
                    Console.WriteLine(myNum+10);

                }
                else if (myNum>=10&&myNum<=99)
                {
                    Console.WriteLine(myNum + 100);

                }
                else if (myNum>=100&&myNum<=999)
                {
                    Console.WriteLine(myNum +1000);

                }
                else if (myNum>=1000&&myNum<=9999)
                {
                    Console.WriteLine(myNum +10000);
                }
                else if (myNum>=10000&&myNum<=99999)
                {
                    Console.WriteLine(myNum + 100000);

                }
                else if (myNum>=100000&&myNum<=999999)
                {
                    Console.WriteLine(myNum + 1000000);

                }
                else if (myNum>=1000000&&myNum<=9999999)
                {
                    Console.WriteLine(myNum + 10000000);
                }
                else if (myNum>=10000000&&myNum<=99999999)
                {
                    Console.WriteLine(myNum +100000000);
                }
            }
            
        }
    }
}
