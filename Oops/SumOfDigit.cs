using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class SumOfDigit
    {
        public static void Digit()
        {
            Console.WriteLine("enter the digit");
            int n = Convert.ToInt32(Console.ReadLine());

            int rem ;
            int sum = 0;   
            while(n > 0)
            {
                rem = n%10;
                sum = sum +rem;
                n = n/10;
                
            }
            Console.WriteLine(sum);





        }
    }
}
