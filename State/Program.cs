using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            ctx.Init(new IAmOn(ctx));
            ctx.PressedOff();
            ctx.PressedOff();
            ctx.PressedOn();
            ctx.PressedOn();
            ctx.PressedOff();
            ctx.PressedOn();
            ctx.FixIt();
            ctx.PressedOn();
        }
    }
}
