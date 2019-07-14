using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class LoginFailed : LoginBase
    {
        private int counter;
        public LoginFailed(Context ctx) : base(ctx)
        {
            counter = 2;
        }

        public override void Login(string password)
        {
            if (string.Equals(password, "PASSWORD"))
            {
                Console.WriteLine("Login successful!");
                this.ctx.State = new LoginSucceed(this.ctx);
            }
            else
            {
                Console.WriteLine("Login failed!");
                counter--;
                if (counter == 0)
                {
                    Console.WriteLine("Failed to login 3 times you are locked");
                    this.ctx.State = new Locked(this.ctx);
                }
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting");
            this.ctx.State = new NewLogin(this.ctx);
        }
    }
}
