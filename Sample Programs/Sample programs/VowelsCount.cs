using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class VowelsCount
    {
        public  VowelsCount()
        {
            Console.WriteLine("Enter Name");
            string var = Console.ReadLine();
            int temp = 0;
            var = var.ToLower();
            string a = "aeiou";
            for (int i=1;i<a.Length;i++)
            {
                   temp= 0;
                for (int j=1;j<var.Length;j++)
                {
                    if (a[i]==var[j])
                        temp++;
                }
                Console.WriteLine($"the count of {a[i]} is {temp}");
            }
        }
    }
}
