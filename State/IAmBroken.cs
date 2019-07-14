using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : StateBase
    {
        public IAmBroken(Context context) : base(context)
        {

        }

        public override void TurnOff()
        {
            Console.WriteLine("You can't turn off, I am broken :(");
        }

        public override void TurnOn()
        {
            Console.WriteLine("You can't turn on, I am broken :(");
        }

        public override void Fix()
        {
            Console.WriteLine("Yay, you fixed me");
            this.ctx.State = new IAmOff(this.ctx);
        }
    }
}
