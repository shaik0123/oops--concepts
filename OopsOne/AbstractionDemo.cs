using System;
using System.Collections.Generic;
using System.Text;

namespace OopsOne
{
    public abstract class AbstractionDemo
    {
        public abstract void Student(); 
        public  void StudentName()
        {
            Console.WriteLine("student name is ram ");
        }
    }
    public class Check : AbstractionDemo
    {
        public override void Student()
        {
            Console.WriteLine("he is a boxer");
        }

    }
}
