using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question10
{
    public class ShadowingOption : WindowOptionsDecoratorBase
    {
        public ShadowingOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " shadowing";
        }
    }
}
