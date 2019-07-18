using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question3
{
    public class CarControlFacade : ICar, IMonitorable
    {
        protected CarControl carControl;

        public CarControlFacade()
        {
            this.carControl = new CarControl();
        }

        public void GetPosition()
        {
            carControl.GetPosition();
        }

        public void GetTankStatus()
        {
            carControl.GetTankStatus();
        }

        public void Left()
        {
            carControl.Left();
        }

        public void Right()
        {
            carControl.Right();
        }

        public void SpeedDown()
        {
            carControl.SpeedDown();
        }

        public void SpeedUp()
        {
            carControl.SpeedUp();
        }

        public void Start()
        {
            carControl.Start();
        }

        public void Stop()
        {
            carControl.Stop();
        }
    }
}
