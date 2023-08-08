using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidhya
{
    class employeeInformation
    {
        public string firstname;
        public string lastname;
        public string emailid;
        public int age;
        public long mobilenumber; 
   
    }

    class Parameters
    {
        public void A(employeeInformation e)
        {
            Console.WriteLine(e.firstname);
            Console.WriteLine(e.lastname);
            Console.WriteLine(e.emailid);
            Console.WriteLine(e.age);
            Console.WriteLine(e.mobilenumber);

        }
        public employeeInformation m()
        {
            employeeInformation obj1 = new employeeInformation();
            Console.WriteLine("Enter First Name");
            obj1.firstname = Console.ReadLine();
            Console.WriteLine("enter Last Name");
            obj1.lastname = Console.ReadLine();
            Console.WriteLine("enter Emailid");
            obj1.emailid = Console.ReadLine();
            Console.WriteLine("Enter Age");
            obj1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mobile number");
            obj1.mobilenumber = Convert.ToInt32(Console.ReadLine());

            return obj1;

        }
    }
}

