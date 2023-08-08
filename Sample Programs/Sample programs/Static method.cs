using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Static_method
    {
        public static int a = 45;
        public int b = 34;
        public static void staticm1()
        {
            
            Console.WriteLine("using static method"+a);
        }
        public void withoutstaticM()
        {
            Console.WriteLine("using without static" + b);
        }
    }
}
