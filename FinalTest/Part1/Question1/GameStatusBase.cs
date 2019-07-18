using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question1
{
    public abstract class GameStatusBase : IGameState
    {
        protected Context ctx;

        public GameStatusBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void NextState(ShipStatusBase shipStatusBase);

        public void Restart()
        {
            ctx.gameState = new NewGame(ctx);
            this.ctx.shipState = new FixedState(ctx);
        }
    }
}
