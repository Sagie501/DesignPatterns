using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    public interface ILoginState
    {
        void Login(string password);

        void Restart();
    }
}
