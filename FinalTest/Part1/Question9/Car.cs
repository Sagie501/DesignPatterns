using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question9
{
    public class Car
    {
        protected string pah;
        protected int wheels;
        protected int sits;
        protected string engine;
        protected string lightSystem;
        protected string battery;

        public Car(string pah, int wheels, int sits, string engine, string lightSystem, string battery)
        {
            this.pah = pah;
            this.wheels = wheels;
            this.sits = sits;
            this.engine = engine;
            this.lightSystem = lightSystem;
            this.battery = battery;
        }
    }
}
