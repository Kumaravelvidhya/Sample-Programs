using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    partial class Conditional_Statement_if
    {
        public void m1()                                           //odd or even
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("if number is Event number") ;
            }
            else
            {
                Console.WriteLine("if number is odd number");
            }
        }
        public void m2()                                       //leap year
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                
                Console.WriteLine("its leap year");
            }
            else
            {
                Console.WriteLine("its not leap year");
            }
        }
    }
}
