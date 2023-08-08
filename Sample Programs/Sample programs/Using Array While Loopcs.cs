using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Using_Array_While_Loops
    {
      
        
            public void total1()
        {
            int i = 0;
            int temp = 0;
            int[] a = { 10, 20, 30, 40, 50 };
            while ( i < a.Length )
            {
                temp = temp + a[i];
                i++;
            }
            
            Console.WriteLine(temp);
        }
        

    }
}
