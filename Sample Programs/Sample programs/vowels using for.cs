using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class vowelsusingfor
    {
        public void gettingdynamicvalue()
        {
            string v;
            Console.WriteLine("Enter You Name");

            v = Console.ReadLine();
            v = v.ToLower();
            int temp = 0;
            int temp1 = 0;

            for (int a = 0; a < v.Length ; a++)
            {
                if (v[a] == 'a' || v[a] == 'e' || v[a] == 'i' || v[a] == 'o' || v[a] == 'u')
                {
                    temp = temp + v[a];
                    Console.WriteLine(v[a]);
                    temp++;
                }

                

                else
                {
                    Console.WriteLine(v[a]);
                    temp1++;
                }
            }
            Console.WriteLine(temp);
            Console.WriteLine(temp1);

        }
    }
}


   