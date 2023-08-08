using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Refkeyword
    {
        public void P(ref int num)
        {

        }
        public void p1()
        {
            int value = 10;
            P(ref value);
            Console.WriteLine(value);
        }
       
        
            


    }
}
