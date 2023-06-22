using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public abstract class Shape
    {
        public abstract  void CalculateArea();
    }
    public class Rectangle : Shape { 

      public override void CalculateArea()
      {
            int width = 5;
            int height = 5;
            int AreaOfRectangle = width * height;
            Console.WriteLine("area of rectangle : "+AreaOfRectangle);

      }
      
    }
    public class Circle : Shape
    {
        public override void CalculateArea()
        {
            int Radius = 5;
            int AreaOfCircle = (int)Math.PI * Radius * Radius;
            Console.WriteLine("area of circle : " + AreaOfCircle);
        }
    }
}
