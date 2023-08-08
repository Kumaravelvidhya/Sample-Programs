using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class ReturnType
    {
        public int price()
        {


            Console.WriteLine("enter apple price");
            int apple = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter apple kg");
            int apple1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter orange price");
            int orange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter orange kg");
            int orange1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter tomato price");
            int tomato = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter tomato kg");
            int tomato1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter potato price");
            int potato = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter potato kg");
            int potato1 = Convert.ToInt16(Console.ReadLine());
            int total;
            total = apple * apple1 + orange * orange1 + tomato * tomato1 + potato * potato1;
            return total;


        }
    }
    class ReturnType2
    {
        public void value()
        {
            ReturnType obj = new ReturnType();
            int total = obj.price();

            Console.WriteLine(total);
        }
    }
}
