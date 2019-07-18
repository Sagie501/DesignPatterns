using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question9
{
    public class RegularCarFactory : AbstractFactory
    {
        public override Car getCar()
        {
            return new RegularCar("pah", 4, 5, "good engine", "light system", "battery");
        }
    }
}
