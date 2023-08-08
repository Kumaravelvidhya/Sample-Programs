using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class gettinguserinfo
    {
        public string name;
        public int Age;
        public string Qualification;

        public void data()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Age");
            int Age =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Qualification");
            string Qualification= Console.ReadLine();

            this.name = name;
            this.Age = Age;
            this.Qualification = Qualification;
           Console.WriteLine($"name:{name}  Age:{Age}  Qualification:{Qualification}");
            
        }
        public void parameter(string name,int Age,string Qualification)
        {
  

            Console.WriteLine($"name:{name}  Age:{Age}  Qualification:{Qualification}");

        }

    }
}
