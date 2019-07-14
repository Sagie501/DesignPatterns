using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class NewLogin : LoginBase
    {
        public NewLogin(Context ctx) : base(ctx)
        {

        }

        public override void Login(string password)
        {
            if (string.Equals(password,"PASSWORD"))
            {
                Console.WriteLine("Login successful!");
                this.ctx.State = new LoginSucceed(this.ctx);
            } else
            {
                Console.WriteLine("Login failed!");
                this.ctx.State = new LoginFailed(this.ctx);
            }
        }

        public override void Restart()
        {

        }
    }
}
