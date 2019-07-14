using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public abstract class LoginBase : ILoginState
    {
        protected Context ctx;

        public LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);

        public abstract void Restart();
    }
}
