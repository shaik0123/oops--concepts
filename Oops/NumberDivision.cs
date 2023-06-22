using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class NumberDivision
    {
        public static void  Division() {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n%2 == 0)
            {
                Console.WriteLine("divided by 2");
            }
            else
            {
                Console.WriteLine("not divided by 2");
            }
        }
    }
}
