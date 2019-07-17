using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public abstract class FormulaDecortorBase : IFormula
    {
        protected IFormula formula;
        protected double number;

        public FormulaDecortorBase(IFormula formula, double number)
        {
            this.formula = formula;
            this.number = number;
        }

        public abstract string GetFormula();

        public abstract double GetResult();
    }
}
