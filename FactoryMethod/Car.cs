using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Car : Vehicle
    {
        protected string drivingWheelHeater;

        public Car(string model, float cylinder, string color, int numOfWheels, string drivingWheelHeater) : base(model, cylinder, color, numOfWheels)
        {
            this.drivingWheelHeater = drivingWheelHeater;
        }

        public override string ToString()
        {
            return "Car " + base.ToString() + $" {drivingWheelHeater}";
        }
    }
}
