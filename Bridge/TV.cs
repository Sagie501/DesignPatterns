using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : EnterDevice
    {
        public TV(int state, int max, bool isOn) : base(state, max, isOn)
        {
        }

        public override void PressNext()
        {
            base.PressNext();
            Console.WriteLine("Current channel is: " + this.state);
        }

        public override void PressPrevious()
        {
            base.PressPrevious();
            Console.WriteLine("Current channel is: " + this.state);
        }

        public override void PrintStatus()
        {
            Console.WriteLine("The TV is " + (this.isOn ? "on" : "off") + ", and the current channel is: " + this.state);
        }
    }
}
