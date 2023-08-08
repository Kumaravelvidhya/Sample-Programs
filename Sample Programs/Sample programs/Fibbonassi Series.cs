using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class FibbonassiSeries
    {
        public FibbonassiSeries()           //0 1 1 2 3 5
        {
            int a = 0;
            int b = 1;
            int temp = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int j=0;j<10;j++)
            {
                temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine(temp);
                
            }
                
                
        }

    }
}
