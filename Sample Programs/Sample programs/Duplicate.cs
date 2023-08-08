using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Duplicate
    {
        public void contain()
        {
            string a = "Impossible";
            a = a.ToLower();
            string duplicate = string.Empty;
            string temp = string.Empty;
            int count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (temp.Contains(a[i]))
                {
                   if (!(duplicate.Contains(a[i])))
                    {
                        duplicate = duplicate + a[i];
                        count++;
                    } 
                }
                else
                {
                    temp = temp + a[i];
                }
            }
            Console.WriteLine(temp);       //   non duplicate
            Console.WriteLine(duplicate);  //    duplicate
            Console.WriteLine(count);       //duplicate characters
            Console.WriteLine(temp.Length);  //count of non duplicate
        }

    }
}
