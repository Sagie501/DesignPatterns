using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseTopping : ToppingDecoratorBase
    {
        public CheeseTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return this.pizza.GetDetails() + " cheese";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 5;
        }
    }
}
