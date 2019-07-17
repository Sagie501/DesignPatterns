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
            StartNumber startNumber = new StartNumber(5);
            IFormula formula = new Add(new Mul(new Sub(new Div(new Add(new Mul(startNumber, 2), 100), 12), 3), 4), 7);
            Console.WriteLine(formula.GetFormula() + " = " + formula.GetResult());
            startNumber.SetNumber(30);
            IFormula newFormula = new Add(new Mul(new Sub(new Div(new Add(new Mul(startNumber, 2), 100), 12), 3), 4), 7);
            Console.WriteLine(formula.GetFormula() + " = " + formula.GetResult());
        }
    }
}
