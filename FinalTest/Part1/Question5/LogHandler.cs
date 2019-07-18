using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question5
{
    public abstract class LogHandler
    {
        protected LogHandler next;

        public void SetNext(LogHandler handler)
        {
            this.next = handler;
        }

        public abstract void Log(string message, LogLevelEnum level);
    }
}
