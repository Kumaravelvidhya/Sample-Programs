using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Using_While_Vowels_Count
    {
        
        public void vowels()
        {
            int i = 0;
            string a = "Getting";
            a = a.ToLower();
            int count = 0;
            int count1 = 1;

            while (i<a.Length)
                {
                if  (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    count++;
                   
                }
                else
                {
                    count1++;
                }
                      i++;
            }

            Console.WriteLine(count);
            Console.WriteLine(count1);
        }  
    }
}
