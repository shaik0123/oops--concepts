using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class Polymorphism
    {
        /*public int a = 10;
        public int b = 20;
        public int c = 30;
        */
        public static void add(int a, int b)
        {
            int x = a + b;
            Console.WriteLine(x);

        }
        public static void add(int a, int b,int c)
        {
            int y = a + b + c;
            Console.WriteLine(y);

        }

    }
}
