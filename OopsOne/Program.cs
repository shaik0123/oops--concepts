using System;

namespace OopsOne
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* Check check = new Check();
             check.StudentName();
             check.Student();*/

            /* Validation v = new Validation();
             v.Valid();

             ValidationOne v1 = new ValidationOne();
             v1.ValidOne();

             BothValidation bothValidation = new BothValidation();   
             bothValidation.Valid();
             bothValidation.ValidOne();*/

            /* Encapsulation e = new Encapsulation();
             e.Name = "Test";
             e.Stdid = 1;
             Console.WriteLine(e.Name + "  " + e.Stdid + "  " + e.SchoolName);*/
             ClassA classA = new ClassA();
            classA.A();
            ClassB classB = new ClassB();
            classB.A();
            classB.B();
            ClassC.C();

            


        }
    }
}
