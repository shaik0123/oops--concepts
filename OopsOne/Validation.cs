using System;
using System.Collections.Generic;
using System.Text;

namespace OopsOne
{
    interface Ichild
    {
        public void Valid();
    }
    interface IAdult
    {
        public void ValidOne();
    }
    public class Validation : Ichild
    {
        public void Valid()
        {
            Console.WriteLine("child not elgible for vote");
        }
    }
    public class ValidationOne : IAdult
    {
        public void ValidOne() 
        {
            Console.WriteLine("Adult elgible for vote");        
        }

    }
    public class BothValidation : Ichild,IAdult 
    {
        public void Valid()
        {
            Console.WriteLine("child not elgible for vote");
        }
        public void ValidOne()
        {
            Console.WriteLine("Adultelgible for vote");
        }
    }
   
}
