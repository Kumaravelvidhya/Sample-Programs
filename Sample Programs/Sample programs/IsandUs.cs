using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class IsandUs
    {
        public void Iskeyword()
        {
            var a = 1234;
            if (a is int)

            {
                Console.WriteLine("value");
            }
                else
            {
                Console.WriteLine("string");
            }
        }
        public IsandUs()
        {
            int number;
            Getvalue(out number);
            Console.WriteLine("modified value:" + number);

        }
        public void Getvalue(out int value)
        {
            value = 10;
        }
        public void Askeyword()
        {
            object[] MyObjects = new object[4];
            MyObjects[0] = 1;
            MyObjects[1] = "hello";
            MyObjects[2] = "Student";
            MyObjects[3] = "Teacher";
            for (int i = 0; i < 4; i++)
            {
                string s = MyObjects[i] as string;
                Console.Write( MyObjects[i]);
                if (s == null)
                {
                    Console.Write("yes");
                }
                else
                {
                    Console.Write(" no ");
                }
               
            }
           

        }
        

        


    }
}
