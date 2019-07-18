using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question9
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool isHybrid)
        {
            if (isHybrid)
            {
                return new HybridCarFactory();
            }
            else
            {
                return new RegularCarFactory();
            }
        } 
    }
}
