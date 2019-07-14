using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class Locked : LoginBase
    {
        public Locked(Context ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            Console.WriteLine("You can't login, you are locked!");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting");
            this.ctx.State = new NewLogin(this.ctx);
        }
    }
}
