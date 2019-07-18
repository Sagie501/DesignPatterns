using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question5
{
    class ErrorLogHandler : LogHandler
    {
        public override void Log(string message, LogLevelEnum level)
        {
            Console.WriteLine("Writing to file...");
            if (level < LogLevelEnum.Error && next != null)
                next.Log(message, level);
        }
    }
}
