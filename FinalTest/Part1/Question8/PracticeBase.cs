using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question8
{
    public abstract class PracticeBase : TemplatePractice
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("Changing clothes");
        }

        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking water");
        }

        protected override void Shower()
        {
            Console.WriteLine("Taking a good shower");
        }
    }
}
