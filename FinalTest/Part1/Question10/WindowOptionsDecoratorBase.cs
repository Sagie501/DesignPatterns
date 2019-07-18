using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question10
{
    public abstract class WindowOptionsDecoratorBase : IWindow
    {
        protected IWindow window;

        public WindowOptionsDecoratorBase(IWindow window)
        {
            this.window = window;
        }

        public abstract string GetDetails();
    }
}
