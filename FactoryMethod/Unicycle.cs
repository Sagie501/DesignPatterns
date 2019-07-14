using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Unicycle : Vehicle
    {
        protected string chairModel;

        public Unicycle(string model, float cylinder, string color, int numOfWheels, string chairModel) : base(model, cylinder, color, numOfWheels)
        {
            this.chairModel = chairModel;
        }

        public override string ToString()
        {
            return "Unicycle " + base.ToString() + $" {chairModel}";
        }
    }
}
