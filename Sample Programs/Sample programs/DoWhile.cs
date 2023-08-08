using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class DoWhile
    {
        public DoWhile()
        {
            int b ;
           
            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.dosa");
                Console.WriteLine("2.Pongal");
                Console.WriteLine("Enter dish number");
                b = Convert.ToInt32(Console.ReadLine());

                switch(b)
                {
                    case 1:
                        Console.WriteLine("no of dosa");
                        int first = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{first } dosa");
                        int a = 12;
                        Console.WriteLine("Price");
                        Console.WriteLine(a * first);                      
                        break;
                    case 2:
                        Console.WriteLine("no of pongal");
                        int sub1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{sub1 } pongal");
                        int c = 50;
                        Console.WriteLine("Price");
                        Console.WriteLine(b * sub1);

                        break;
                    default:
                        Console.WriteLine("Please give a valid OPtion");
                        break;
                }

            } while (b != 0);


        }
    }
}
