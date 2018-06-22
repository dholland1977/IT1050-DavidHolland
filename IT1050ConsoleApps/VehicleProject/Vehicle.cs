using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleProject
{
    public class Vehicle
    {
        #region Properties
        public string color;
        public string make;
        public string model;
        public int speed;
        #endregion

        #region Methods
        public string Describe()
        {
            return $"This {make} {model} is {color} and is going {speed} MPH.";
        }

        public void speedUp()
        {
            speed = speed + 1;
        }

        public void slowDown()
        {
            speed = speed - 1;
        }
        #endregion
    }
}
