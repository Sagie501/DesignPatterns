using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question1
{
    public abstract class ShipStatusBase : IShipState
    {
        protected Context ctx;

        public ShipStatusBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract string getShipStatus();
    }
}
