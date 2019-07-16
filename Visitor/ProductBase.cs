using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class ProductBase
    {
        public double price { set; get; }
        public ProductBase(double price)
        {
            this.price = price;
        }
    }
}
