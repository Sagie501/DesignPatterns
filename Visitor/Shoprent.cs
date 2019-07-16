using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Shoprent : IVisitable
    {
        public double price;

        public Shoprent(double price)
        {
            this.price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Shoprent price: {price}";
        }
    }
}
