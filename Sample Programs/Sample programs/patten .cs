﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class patten
    {
        public patten()
        {
            for (int i=1;i<=4;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }            
        }
    }
}
