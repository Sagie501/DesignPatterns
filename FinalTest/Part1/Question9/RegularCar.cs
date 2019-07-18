using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question9
{
    public class RegularCar : Car
    {
        public RegularCar(string pah, int wheels, int sits, string engine, string lightSystem, string battery) : base(pah, wheels, sits, engine, lightSystem, battery)
        {
        }

        public override string ToString()
        {
            return "Regular car";
        }
    }
}
