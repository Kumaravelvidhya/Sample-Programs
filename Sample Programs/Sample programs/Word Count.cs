using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Word_Count
    {
        public void WordCount1()
        {

            string p = Console.ReadLine();
            int temp = 0;
            p = p.Trim();
            for(var i=0;i<p.Length;i++)
            {
                if (p[i] == ' ') 
                { 
                temp++;
                }
            }
            Console.WriteLine(temp+1);
        }
        public void wordcount2()
        {
            string pp = Console.ReadLine();
            var pv = pp.Split(' ');
            Console.WriteLine(pv.Length);
        }
    }
}
