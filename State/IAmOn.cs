using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOn : StateBase
    {

        public IAmOn(Context context) : base(context)
        {
            
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning off the light...");
            this.ctx.State = new IAmOff(this.ctx);
        }

        public override void TurnOn()
        {
            Console.WriteLine("You broke it!!!");
            this.ctx.State = new IAmBroken(this.ctx);
        }

        public override void Fix()
        {
            Console.WriteLine("I am working fine");
        }
    }
}
