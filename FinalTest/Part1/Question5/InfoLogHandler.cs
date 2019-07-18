using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question5
{
    class InfoLogHandler : LogHandler
    {
        public override void Log(string message, LogLevelEnum level)
        {
            Console.WriteLine("[" + level.ToString() + "] " + message);
            if (level < LogLevelEnum.Info && next != null)
                next.Log(message, level);
        }
    }
}
