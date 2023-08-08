using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class ConstructorsTypes
    {
        public ConstructorsTypes()                          //constructors
        {
            Console.WriteLine("Date and Time:" + DateTime.UtcNow);
        }
        public ConstructorsTypes(string value)             //paramether constructors
        {
            Console.WriteLine("Date and Time:"+ DateTime.Now+ value );

        }
        static ConstructorsTypes()                        //static constructors
        {
            Console.WriteLine("Time Calculation");
        }

    }

}
