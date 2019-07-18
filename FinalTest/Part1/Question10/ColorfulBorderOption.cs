using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question10
{
    public class ColorfulBorderOption : WindowOptionsDecoratorBase
    {
        public ColorfulBorderOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " colorful border";
        }
    }
}
