using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Factorialsprogram1
    {
        public  Factorialsprogram1()
        {
            Console.WriteLine("Enter Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = 1;
            for(int i=0;i<a;i++)
            {
                temp = temp * a;
            }
            Console.WriteLine(temp);
        }
    }
}
