using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl(new Memir(1, 100, false));
            remoteControl.PrintStatus();
            remoteControl.Next();
            remoteControl.On();
            remoteControl.PrintStatus();
            remoteControl.SetEnterDevice(new TV(8, 50, true));
            remoteControl.PrintStatus();
            remoteControl.Prev();
            remoteControl.Off();
            remoteControl.PrintStatus();
        }
    }
}
