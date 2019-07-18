using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question5
{
    public class FatalLogHandler : LogHandler
    {
        public override void Log(string message, LogLevelEnum level)
        {
            Console.WriteLine("Sending SMS to manager...");
            if (level < LogLevelEnum.Fatal && next != null)
                next.Log(message, level);
        }
    }
}
