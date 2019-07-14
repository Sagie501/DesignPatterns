using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOff : StateBase
    {

        public IAmOff(Context context) : base(context)
        {

        }

        public override void TurnOff()
        {
            Console.WriteLine("Light is already off...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turning on the light...");
            this.ctx.State = new IAmOn(this.ctx);
        }

        public override void Fix()
        {
            Console.WriteLine("I am working fine");
        }
    }
}
