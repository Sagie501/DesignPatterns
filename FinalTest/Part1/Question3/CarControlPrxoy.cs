using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question3
{
    public class CarControlPrxoy : IMonitorable
    {
        public void GetPosition()
        {
            CarControlFacade carControlFacade = new CarControlFacade();
            carControlFacade.GetPosition();
        }

        public void GetTankStatus()
        {
            CarControlFacade carControlFacade = new CarControlFacade();
            carControlFacade.GetTankStatus();
        }
    }
}
