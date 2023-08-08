using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class vowels_using_loop
    {
       public void vowels()
        {
            string a = "Is Vidhya ";
            int temp = 0;
            int temp1 = 0;
            //char b = new char();
            a = a.ToLower();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    temp++;
                    Console.WriteLine (a[i]);
                }
                else
                {
                    temp1++;
                    Console.WriteLine(a[i]);
                }
                    

            }
            Console.WriteLine(temp);
            Console.WriteLine(temp1);
        }
    }
}
