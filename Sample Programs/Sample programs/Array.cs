using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class Array
    {
        public string name;
        public int tamil;
        public int english;
        public int maths;
        public int science;
        public int social;
        public int total;
        public int average;
        

        public void marklist()
        {
            Array[] s1 = new Array[2];
            s1[0] = new Array();
            Console.WriteLine("enter your name");
            s1[0].name = Console.ReadLine();
            Console.WriteLine("enter tamil mark");
            s1[0].tamil = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter english mark");
            s1[0].english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter maths mark");
            s1[0].maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter science mark");
            s1[0].science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter social mark");
            s1[0].social = Convert.ToInt16(Console.ReadLine());
            s1[0].total = s1[0].tamil + s1[0].english + s1[0].maths + s1[0].science + s1[0].social;
            Console.WriteLine("total");
            Console.WriteLine(s1[0].total);
            Console.WriteLine("averagemark");
            s1[0].average = s1[0].total / 5;          
            Console.WriteLine(s1[0].average);
            Console.WriteLine(" grade");
            if (s1[0].average >= 100 && s1[0].average >= 100) 
            {
                Console.WriteLine("A");
               
            }
            else if  (s1[0].average >= 81 && s1[0].average >= 90) 
            {
                Console.WriteLine("B");
            }
            else if (s1[0].average <= 49)
            {
                Console.WriteLine("c");

            }
          
            else  
            {
                Console.WriteLine("d");
            }
          
            Array[] s2 = new Array[2];
            s2[1] = new Array();
            Console.WriteLine("enter your name");
            s2[1].name = Console.ReadLine();
            Console.WriteLine("enter tamil mark");
            s2[1].tamil = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter english mark");
            s2[1].english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter maths mark");
            s2[1].maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter science mark");
            s2[1].science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter social mark");
            s2[1].social = Convert.ToInt16(Console.ReadLine());
            s2[1].total = s2[1].tamil + s2[1].english + s2[1].maths + s2[1].science + s2[1].social;
            Console.WriteLine("total");
            Console.WriteLine(s2[1].total);
            Console.WriteLine("averagemark");
            s2[1].average = s2[1].total / 5;           
            Console.WriteLine(s1[0].average);
            Console.WriteLine(" grade");
            if (s1[0].average >= 100 && s1[0].average >= 100)
            {
                Console.WriteLine("A");

            }
            else if (s1[0].average >= 81 && s1[0].average >= 90)
            {
                Console.WriteLine("B");
            }
            else if (s1[0].average >= 71 && s1[0].average >= 80)
            {
                Console.WriteLine("c");

            }
            else
            {

            }







        }


    }
}
