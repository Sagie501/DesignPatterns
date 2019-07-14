using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public class Context
    {
        public ILoginState State { get; set; }

        public Context()
        {

        }

        public void Init(ILoginState state)
        {
            this.State = state;
        }

        public void Login(string password)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.Login(password);
        }

        public void Restart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");
            State.Restart();
        }
    }
}
