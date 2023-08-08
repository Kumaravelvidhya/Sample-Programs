using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class WordRevers
    {
        public WordRevers()
        {
            Console.WriteLine("word reverse");
           // Console.ForegroundColor = ConsoleColor.DarkGreen;

            string a = Convert.ToString(Console.ReadLine());

            string[] result = a.Split (' ');

            for (int i=result.Length-1; i>=0; i--)
            {
                Console.Write(result[i] +' ');
               
            }

        }
    }
}
