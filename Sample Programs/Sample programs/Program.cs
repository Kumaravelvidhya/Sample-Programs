using System;
using vidhya1;
using Registrationrepository;
using Registrationrepository;

namespace vidhya
{ 
    class Program
    {
        static void Main(string[] args)
        {
             Registrationrepository1 obj = new Registrationrepository1();               //sql connection
             var data = obj.addata();                                                 
             obj.Insert(data);                                                        //sql insert
             obj. Select();                                                           //sql select
             obj.Dowhilemenu();                                                     //dowhile menu
           
            // (patten)
            // patten obj = new patten();        

            // ArrayLoopscs obj = new ArrayLoopscs();

            //(WordRevers)
            // WordRevers obj = new WordRevers();

            //(FibbonassiSeries)
            // FibbonassiSeries obj = new FibbonassiSeries();

            //(DoWhile)
            //DoWhile obj = new DoWhile();

            //(CompareArrayValue)
            // CompareArrayValue obj = new CompareArrayValue();

            //(Factorialsprogram1)
            //Factorialsprogram1 obj = new Factorialsprogram1();

            //VowelsCount obj1 = new VowelsCount();

            //(Armstrongnumbers )
            //Armstrongnumbers obj = new Armstrongnumbers();


            //Class1 obj = new Class1();
            //obj.classname()  ;

            //(is and us keywords)
            // IsandUs obj = new IsandUs();
            //obj.Iskeyword();
            //obj.Askeyword();

            // ReversNumbers obj = new ReversNumbers();
            // obj. revers();                  //revers

            // (refkeyword)
            // Refkeyword obj = new Refkeyword();
            // obj.p1();                    //ref

            // (switch)
            // Switch obj = new Switch();
            //obj.Days();
            // obj.breakkeyword();              // breakkeyword()

            // Word_Count obj = new Word_Count();
            // obj.WordCount1();
            // obj.wordcount2();

            //Using_Array_While_Loops obj = new Using_Array_While_Loops();
            //obj.total1();

            //(While loop with vowels)
            //Using_While_Vowels_Count obj = new Using_While_Vowels_Count();
            //obj.vowels();

            //(swap)
            //Swap obj = new Swap();
            //obj.Swap1();
            //obj.Swap2();

            //(dupilication)
            //Duplicate obj = new Duplicate();
            //obj.contain();

            //(revers program .palindrome)
            //Revers obj = new Revers();
            //obj.reversprogram();

            //(property)
            //property2 obj = new property2();
            //obj.modelmethod();

            //vowels_using_loop obj = new vowels_using_loop();
            //obj.vowels();

            //vowelsusingfor obj = new vowelsusingfor();
            //obj.gettingdynamicvalue();

            //(Ternary_Operators)
            //Ternary_Operators obj = new Ternary_Operators();
            //obj.Operators();

            //(using array sum the value)
            // Array_Using_For_Loop obj = new Array_Using_For_Loop();                
            //obj.Total();

            //(for loop and if)
            //For_Loop obj = new For_Loop();                                         
            //obj.looping();

            //(dynamic value)
            // value obj = new value();                                                 
            //obj.total1();

            //(vechicles)
            // var obj = new vehiclesinfo();
            //obj.getinsurename();
            //obj = new vehiclesinfo("vidhya");
            //obj.getinsurancenumber();


            /*marks obj = new marks();
            students[] list = obj.studentinfo();
            Console.WriteLine($"name:{list[0].Name}and grade is :{obj.Grade(list[0])}");  //student 1
            Console.WriteLine($"name:{list[1].Name}and grade is :{obj.Grade(list[1])}");  //student 2/*

            // Array obj = new Array();
            //obj.marklist();

            // vowels obj = new vowels();
            //obj.vowelslet();

            /* Conditional_Statement_if obj = new Conditional_Statement_if();
             obj.a1();             //if
             obj.a2();             //if else
             obj.m1();             //odd or even
             obj.m2();             //leap year


                 //Static_Class.information();                                 //static class

             /*Static_method.staticm1();
             Static_method obj = new Static_method();                      //static
             obj.withoutstaticM();*/


            //ConstructorsTypes vab = new ConstructorsTypes();
            //ConstructorsTypes vab1 = new ConstructorsTypes("India"); //parameters



            /* Constructors obj = new Constructors();

             obj.Totalmark(40);
             obj.avergemark();

             /*Parameters obj = new Parameters();
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

             obj.A(obj1);

             obj.A(obj1);
             employeeInformation obj2 = obj.m();


             Console.WriteLine("Enter First Name");
             obj1.firstname = Console.ReadLine();
             Console.WriteLine("enter Last Name");
             obj1.lastname = Console.ReadLine();
             Console.WriteLine("enter Emailid");
             obj1.emailid = Console.ReadLine();
             Console.WriteLine("Enter Age");
             obj1.age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Mobile number");
             obj1.mobilenumber = Convert.ToInt32(Console.ReadLine());/*

             //ReturnType2 obj = new ReturnType2();
             //obj.value();


             //gettinguserinfo objinfo = new gettinguserinfo();
             //objinfo.data();
             // objinfo.parameter("x", 23, "bsc");
             /* operatorsexample objvariable = new operatorsexample();
              objvariable.arithmetic();
              objvariable.assignment();
              objvariable.comparission();
              objvariable.logic();*/

            // gettinguserinfo objinfo1 = new gettinguserinfo();
            // objinfo1.data();

            //typecasting objmarks = new typecasting();
            //objmarks.readmark();
            // objmarks.averagecalculation();

            //vidhyaclass1 objvariable = new vidhyaclass1();
            //objvariable.print2();

            // userinformations objvariable = new userinformations();
            //objvariable.Print();

            // agecalculation objVariable = new agecalculation();
            //objVariable.print();


        }
    }
}
