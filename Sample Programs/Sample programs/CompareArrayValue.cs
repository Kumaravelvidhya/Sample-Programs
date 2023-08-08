using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class CompareArrayValue
    {
       public  CompareArrayValue()
        {
            int[] a = new int[]{ 1,2,3,4 };
            int[] b = new int[] { 1, 2, 3, 5};
            int temp = 0;
            if(a.Length==b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        temp++;
                    }
                }
                       if(temp==b.Length)
                        {
                            Console.WriteLine("is equal");
                        }
                       else
                        {
                            Console.WriteLine("is not equal");
                        }
                    
                
            }    
        }
    }
}
