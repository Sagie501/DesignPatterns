using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question1
{
    public class DangerState : ShipStatusBase
    {
        public DangerState(Context ctx) : base(ctx)
        {
        }

        public override string getShipStatus()
        {
            return "DANGER";
        }
    }
}
