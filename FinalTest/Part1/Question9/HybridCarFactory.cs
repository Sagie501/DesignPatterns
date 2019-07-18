using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question9
{
    public class HybridCarFactory : AbstractFactory
    {
        public override Car getCar()
        {
            return new HybridCar("pah", 4, 5, "good engine", "light system", "battery");
        }
    }
}
