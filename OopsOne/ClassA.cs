using System;
using System.Collections.Generic;
using System.Text;

namespace OopsOne
{
    public class ClassA
    {
       public int a = 1;  
        public int b = 2;
        public void A()
        {

            Console.WriteLine("this is a method");
        }
    }
    public class ClassB : ClassA
    { 
        public  void B()
        {
            int x = a + b;
            Console.WriteLine("this is b method  "+ x);
        }
    }
    public class ClassC : ClassB
    {

        public static void C()
        {

            Console.WriteLine("this is c method");
        }
    }
}
