using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{

    public class Car
    {
        public String carname = "honda";

    }
    public class Vehicle : Car
    {
        public void CarDetails()
        {
            String model = "Electric Vehicle";
            int year = 2023;
            int month = 1;
            Console.WriteLine("car name : "+carname+" model : "+model+" year : "+year+" month : "+month);



        }
    }
}
