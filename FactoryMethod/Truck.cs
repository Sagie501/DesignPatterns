using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Truck : Vehicle
    {
        protected string truckKind;
        public Truck(string model, float cylinder, string color, int numOfWheels, string truckKind) : base(model, cylinder, color, numOfWheels)
        {
            this.truckKind = truckKind;
        }

        public override string ToString()
        {
            return "Truck " + base.ToString() + $" {truckKind}";
        }
    }
}
