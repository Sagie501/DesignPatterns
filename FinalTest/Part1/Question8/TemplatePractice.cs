using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Question8
{
    public abstract class TemplatePractice
    {
        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void Drill();
        protected abstract void Shower();

        public void Run()
        {
            Console.WriteLine("Statrt Practice");
            ChangeClothes();
            DrinkWater();
            Drill();
            Shower();
            Console.WriteLine("Finish Practice");
        }
    }
}
