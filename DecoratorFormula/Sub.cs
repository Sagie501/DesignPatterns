﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public class Sub : FormulaDecortorBase
    {
        public Sub(IFormula formula, double number) : base(formula, number)
        {
        }

        public override string GetFormula()
        {
            return this.formula.GetFormula() + " - " + this.number;
        }

        public override double GetResult()
        {
            return this.formula.GetResult() - this.number;
        }
    }
}
