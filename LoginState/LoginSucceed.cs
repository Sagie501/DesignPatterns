using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class LoginSucceed : LoginBase
    {

        public LoginSucceed(Context ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            Console.WriteLine("You are already logged in");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting");
            this.ctx.State = new NewLogin(this.ctx);
        }
    }
}
