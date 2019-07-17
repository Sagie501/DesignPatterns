using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class EnterDevice
    {
        protected int state;
        protected int max;
        protected bool isOn;

        protected EnterDevice(int state, int max, bool isOn)
        {
            this.state = state;
            this.max = max;
            this.isOn = isOn;
        }

        public abstract void PrintStatus();

        public virtual void PressNext()
        {
            if (this.state < this.max)
            {
                this.state++;
            }
            else
            {
                this.state = 1;
            }
        }

        public virtual void PressPrevious()
        {
            if (this.state > 1)
            {
                this.state--;
            }
            else
            {
                this.state = 1;
            }
        }

        public void TurnOn()
        {
            Console.WriteLine("Turnning on...");
            this.isOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Turnning off...");
            this.isOn = false;
        }
    }
}
