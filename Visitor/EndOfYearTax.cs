using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class EndOfYearTax : IVisitor
    {
        public double Visit(Liquor liquor)
        {
            return liquor.price * 0.8;
        }

        public double Visit(Tabacoo tabacoo)
        {
            return tabacoo.price * 1.55;
        }

        public double Visit(Chocolate chocolate)
        {
            return chocolate.price * 0.9;
        }

        public double Visit(Perfume perfume)
        {
            return perfume.price * 0.95;
        }

        public double Visit(Shoprent shoprent)
        {
            return shoprent.price * 0.7;
        }
    }
}
