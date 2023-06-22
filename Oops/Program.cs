using System;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Inhritance1 inhritance1 = new Inhritance1();
            inhritance1.add();

            Vehicle vehicle = new Vehicle();
            vehicle.CarDetails();

            // Polymorphism polymorphism = new Polymorphism();
            //Polymorphism.add(2,4);
            //Polymorphism.add(3,5,6);
            //Shape shape = new Rectangle();
            //shape.CalculateArea();
            //Shape shape1 = new Circle();
            //shape1.CalculateArea();
            // encapsulation = new Encapsulation();
            //encapsulation.Name = "ismail";
            //encapsulation.Age = 1;
            //NumberDivision.Division
            //SumOfDigit.Digit();
            //Palindrome.palindrome();
        }
    }
}
