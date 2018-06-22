using System;

namespace VehicleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.make = "Ford";
            myCar1.model = "Focus";
            myCar1.color = "blue";

            Car myCar2 = new Car();
            myCar2.make = "Chevy";
            myCar2.model = "Cruze";
            myCar2.color = "red";

            for (int i = 0; i < 35; i++)
            {
                myCar2.speedUp();
                myCar1.speedUp();
                myCar2.speedUp();
            }
            for (int i = 0; i < 10; i++)
            {
                myCar2.slowDown();
            }
            Console.WriteLine(myCar1.Describe());
            Console.WriteLine(myCar2.Describe());

            Console.Read();
        }
    }
}
