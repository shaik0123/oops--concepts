using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Palindrome
    {


        public static void palindrome()
        {
            Console.WriteLine("enter the numbaer");
            int x = Convert.ToInt32(Console.ReadLine());  
            int remainder;
            int sum = 0;
            int temp = x;

            while (x > 0)
            {
                remainder = x % 10;
                sum = sum * 10 + remainder;
                x = x / 10;
            }
            if (temp  == sum)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }

        }
    }
}
