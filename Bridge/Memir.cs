using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Memir : EnterDevice
    {
        public Memir(int state, int max, bool isOn) : base(state, max, isOn)
        {
        }

        public override void PressNext()
        {
            base.PressNext();
            Console.WriteLine("Current program is: " + this.state);
        }

        public override void PressPrevious()
        {
            base.PressPrevious();
            Console.WriteLine("Current program is: " + this.state);
        }

        public override void PrintStatus()
        {
            Console.WriteLine("The Memir is " + (this.isOn ? "on" : "off") + ", and the current program is: " + this.state);
        }
    }
}
