using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Property
    {
        public string Name { get; set; }
        public double Netweight { get; set; }
        public double price { get; set; }
       
    }
    class property2
    {
        public void modelmethod()
        {
            Property a = new Property();
            Console.WriteLine("Enter the array range");
            int size = Convert.ToInt32(Console.ReadLine());
            Property[] b = new Property[size];
            for(int range=0; range < size; range++)
            {
                b[range] = new Property();
                Console.WriteLine("enter name");
                b[range].Name = Console.ReadLine();
                Console.WriteLine("enter netwight");
                b[range].Netweight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter price");
                b[range].price = Convert.ToDouble(Console.ReadLine());
                

            
                Console.WriteLine(b[range].Name);
                Console.WriteLine(b[range].Netweight);
                Console.WriteLine(b[range].price);
            }
            
        }
    }
}