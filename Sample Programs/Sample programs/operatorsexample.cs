using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class operatorsexample
    {
        int c;
        public void arithmetic()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            //converting to int
            int a1 = Convert.ToInt16(a);
            int b1 = Convert.ToInt16(b);
            //(+)
            c = a1 + b1;
            Console.WriteLine(c);
            //(*)
            c = a1 * b1;
            Console.WriteLine(c);
            //(-)
            c = a1 - b1;
            Console.WriteLine(c);
            //(%)
            c = a1 % b1;
            Console.WriteLine(c);
            //(/)
            c = a1 / b1;
            Console.WriteLine(c);
        }
        public void assignment()
        {
            int a = 500;
            int b = 200;
            
            Console.WriteLine(a = b);
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
        }
        public void comparission()
        {
            int a = 100;
            int b = 200;
            Console.WriteLine(a == b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
        }
        public void logic()
        {
            int a = 6; 
            int b = 5;
            int c = 6;
            Console.WriteLine(a >= b && a >= c);
            Console.WriteLine(a >= b || a >= c);
            Console.WriteLine(!(a <= c));

        }



    }
}
