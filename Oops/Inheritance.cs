using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class Inheritance
    {
        protected int a = 12;
        public String stname = "ismail";
        protected int b = 13;
    }
    public class Inhritance1 : Inheritance
    {
     
        public void add()
        {
            int c = a + b;
            Console.WriteLine(c+ "  "+stname);   

        }
        


    }
}
