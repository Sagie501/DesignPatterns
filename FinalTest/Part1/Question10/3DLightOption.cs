using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question10
{
    class _3DLightOption : WindowOptionsDecoratorBase
    {
        public _3DLightOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " 3D lights";
        }
    }
}
