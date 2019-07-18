using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question1
{
    public class NewGame : GameStatusBase
    {
        public NewGame(Context ctx) : base(ctx)
        {
        }

        public override void NextState(ShipStatusBase shipStatusBase)
        {
            this.ctx.shipState = new FixedState(this.ctx);
            this.ctx.gameState = new GameStart(this.ctx);
        }
    }
}
