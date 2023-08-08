using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Revers
    {
        public void reversprogram()
        {
            string name = "vidhya";
            string temp = string.Empty;
            for (int i = 0; i<name.Length; i++) 
            {
                temp = name[i]+temp; 
            }

            Console.WriteLine(temp);
            if (name==temp)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
