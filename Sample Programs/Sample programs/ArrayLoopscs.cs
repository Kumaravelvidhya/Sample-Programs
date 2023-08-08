using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class ArrayLoopscs
    {
        
        public ArrayLoopscs()
        {
            int[] a =new int[] { 90, 50,49,78,9 };
           
            for (int i = 0; i <= a.Length; i++)
            {
                int temp = 0;
                for (int j=i+1;j<a.Length;j++)
                {
                    if (a[i] >a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }

            }
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
        }
            
    }
}
