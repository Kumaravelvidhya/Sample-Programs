using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Swap
    {
        public void Swap1()
        {
            int a = 23;
            int b = 34;
           int c = a;
             a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
        public void Swap2()
        {
            int a = 10;
            int b = 20;
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }

    }
}
