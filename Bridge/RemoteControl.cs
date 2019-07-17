using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        EnterDevice enterDevice;

        public RemoteControl(EnterDevice enterDevice)
        {
            this.enterDevice = enterDevice;
        }

        public EnterDevice GetEnterDevice()
        {
            return this.enterDevice;
        }

        public void SetEnterDevice(EnterDevice enterDevice)
        {
            this.enterDevice = enterDevice;
        }

        public void On()
        {
            this.enterDevice.TurnOn();
        }

        public void Off()
        {
            this.enterDevice.TurnOff();
        }

        public void Next()
        {
            this.enterDevice.PressNext();
        }

        public void Prev()
        {
            this.enterDevice.PressPrevious();
        }

        public void PrintStatus()
        {
            this.enterDevice.PrintStatus();
        }
    }
}
