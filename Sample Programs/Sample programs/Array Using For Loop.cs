using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Array_Using_For_Loop
    {
        public void Total()
        {
            int temp =0 ;
            int[] a = { 10, 20, 30, 40, 50 };
            for (int i = 0; i <a.Length; i++) 
            {
                temp =temp + a[i];
            }
            Console.WriteLine(temp);
        }
    }
    class value
    {
        public void total1()
        {
            int temp1=0;
            Console.WriteLine("enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[size];
           for (int  a=0;a<size;a++)
            {
                Console.WriteLine("enter value");
                s[a] = Convert.ToInt32(Console.ReadLine());
                temp1 = temp1 + s[a];
            }

            Console.WriteLine(temp1);
        }
    }

}
