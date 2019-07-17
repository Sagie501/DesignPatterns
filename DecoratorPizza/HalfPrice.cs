using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HalfPrice : DiscountDecoratorBase
    {
        public HalfPrice(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return this.pizza.GetDetails() + " pizza with 50% discount";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() * 0.5;
        }
    }
}
