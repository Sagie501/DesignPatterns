using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFormula
{
    public class StartNumber : IFormula
    {
        protected double number;

        public StartNumber(double number)
        {
            this.number = number;
        }

        public void SetNumber(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {
            return number.ToString();
        }

        public double GetResult()
        {
            return number;
        }
    }
}
