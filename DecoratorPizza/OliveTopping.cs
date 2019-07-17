using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OliveTopping : ToppingDecoratorBase
    {
        public OliveTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return this.pizza.GetDetails() + " olives";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 3;
        }
    }
}
