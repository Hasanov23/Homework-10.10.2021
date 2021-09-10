using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            //        IF operatoru ile yoxla. 
            //Verilmish ededdin 1 - ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
            //Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster

            int myNum = Convert.ToInt32(Console.ReadLine());
            if (myNum>=1&&myNum<=365)
            {
                if (myNum>=1&&myNum<=31)
                {
                    Console.WriteLine("Yanvar");
                    if (myNum>=1&&myNum<=19)
                    {
                        Console.WriteLine("Oglaq bürcü");
                    }

                }
                else if (myNum>31&&myNum<=59)
                {
                    Console.WriteLine("Fevral");
                    if (myNum>=20&&myNum<=49)
                    {
                        Console.WriteLine("Dolca bürcü");

                    }
                }
                else if (myNum>=60&&myNum<=90)
                {
                    Console.WriteLine("Mart");
                    if (myNum>=50&&myNum<=79)
                    {
                        Console.WriteLine("Baliq bürcü");

                    }
                }
                else if (myNum>=91&&myNum<=121)
                {
                    Console.WriteLine("Aprel");
                    if (myNum>=80&&myNum<=109)
                    {
                        Console.WriteLine("Qoc bürcü");

                    }
                    else if (myNum>=122&&myNum<=152)
                    {
                        Console.WriteLine("May");
                        if (myNum>=110&&myNum<=141)
                        {
                            Console.WriteLine("Buga bürcü");

                        }
                    }
                    else if (myNum>=153&&myNum<=183)
                    {
                        Console.WriteLine("Iyun");
                        if (myNum >= 142 && myNum <= 172)
                        {
                            Console.WriteLine("Ekizler bürcü");

                        }
                    }
                    else if (myNum>=184&&myNum<=214)
                    {
                        Console.WriteLine("Iyul");
                        if (myNum>=173&&myNum<=202)
                        {
                            Console.WriteLine("Xerceng bürcü");

                        }
                    }
                    else if (myNum >= 215 && myNum <= 245)
                    {
                        Console.WriteLine("Avqust");
                        if (myNum >= 203 && myNum <= 243)
                        {
                            Console.WriteLine("Shir bürcü");

                        }
                    }
                    else if (myNum >= 246 && myNum <= 276)
                    {
                        Console.WriteLine("Sentyabr");
                        if (myNum >= 244 && myNum <= 275)
                        {
                            Console.WriteLine("Qiz bürcü");

                        }
                    }
                    else if (myNum >= 276 && myNum <= 307)
                    {
                        Console.WriteLine("Oktyabr");
                        if (myNum >= 276 && myNum <= 307)
                        {
                            Console.WriteLine("Terezi bürcü");

                        }
                    }
                    else if (myNum >= 308 && myNum <= 339)
                    {
                        Console.WriteLine("Noyabr");
                        if (myNum >= 308 && myNum <= 339)
                        {
                            Console.WriteLine("Eqreb bürcü");

                        }
                    }
                    else if (myNum >= 339 && myNum <= 366)
                    {
                        Console.WriteLine("Dekabr");
                        if (myNum >= 340 && myNum <= 356)
                        {
                            Console.WriteLine("Oxatan bürcü");

                        }
                    }
                }
            }
        }
    }
}
