using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class ReversNumbers
    {
        public void revers()
        {
            int no = 1234;
            int rev = 0;
            while(no>0)
            {
                rev=(rev* 10)+no % 10;
                no = no / 10;
            }
            Console.WriteLine(rev);
        }

    }
}
