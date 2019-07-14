using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            ctx.Init(new NewLogin(ctx));
            ctx.Login("worng");
            ctx.Login("worng");
            ctx.Login("worng");
            ctx.Login("worng");
            ctx.Restart();
            ctx.Login("PASSWORD");
            ctx.Login("PASSWORD");
        }
    }
}
