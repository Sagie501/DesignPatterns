using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question3
{
    public class CarControl : ICar, IMonitorable
    {
        public void GetPosition()
        {
            Console.WriteLine("The car position is...");
        }

        public void GetTankStatus()
        {
            Console.WriteLine("The car tank status is..");
        }

        public void Left()
        {
            Console.WriteLine("Turning left..");
        }

        public void Right()
        {
            Console.WriteLine("Turning right..");
        }

        public void SpeedDown()
        {
            Console.WriteLine("Slowing");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speeding up");
        }

        public void Start()
        {
            Console.WriteLine("Start drive");
        }

        public void Stop()
        {
            Console.WriteLine("Stop drive");
        }
    }
}
