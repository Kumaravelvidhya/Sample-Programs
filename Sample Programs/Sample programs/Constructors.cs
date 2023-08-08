using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Constructors
    {
        public int tamil, english, maths, science, social, total, average; //global variable
        


        public Constructors()
        {
             Console.WriteLine("Enter Tamil mark");
             tamil = Convert.ToInt32 (Console.ReadLine());
             Console.WriteLine("Enter English mark");
             english = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Maths mark");
             maths = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Science mark");
             science = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Social mark");
             social = Convert.ToInt32(Console.ReadLine());
            
        }
        public void Totalmark(int tamil)
        {
            total = tamil + english + maths + science + social;
            Console.WriteLine($"total:{total}");

        }
        public void avergemark()
        {
            average = total / 5;
            Console.WriteLine($"Average Mark:{ average}");
            
        }
    }
 
}
