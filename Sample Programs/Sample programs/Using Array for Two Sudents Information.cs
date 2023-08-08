using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class students
    {
        public string Name;
        public int Tamil, english, maths, science, ss;
    }

    class marks
    {
        public int total, average;
        private students Marks()
        {
            students s = new students();
            /* s[0] = new students();
             s[1] = new students();*/
            Console.WriteLine("enter your name");
            s.Name = Console.ReadLine();
            Console.WriteLine("enter your tamil mark");
            s.Tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your english mark");
            s.english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your maths mark");
            s.maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your science mark");
            s.science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your ss mark ");
            s.ss = Convert.ToInt32(Console.ReadLine());
            return s;
        }
        public students[] studentinfo()
        {
            students[] st = new students[2];
            st[0] = Marks();
            st[1] = Marks();
            return st;

        }
        public string Grade(students s)
        {
            total = s.Tamil + s.english + s.maths + s.science + s.ss;
            total = s.Tamil + s.english + s.maths+s.science+s.ss;
            Console.WriteLine($"the total is{total}");
            average = total / 5;
            Console.WriteLine($"the averageis{average}");
            string grade = "GRADE E";

            if (average >= 91 && average <= 100)
            {
                 grade = "GRADE A";

            }


            else if (average >= 81 && average <= 90)
            {
                 grade = "GRADE B";
            }

            else if (average >= 71 && average <= 80)
            {
                grade = "GRADE C";
            }
            else if (average >= 50 && average <= 70)
            {
                grade = "GRADE D";
            }

            else if (average <= 49)
            {
                 grade = "GRADE F";
            }
            return grade;


        }
    }
}
