using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula formula = new Add(new Mul(new Sub(new Div(new Add(new Mul(new StartNumber(5), 2), 100), 12), 3), 4), 7);
            Console.WriteLine(formula.GetFormula() + " = " + formula.GetResult());
        }
    }
}
