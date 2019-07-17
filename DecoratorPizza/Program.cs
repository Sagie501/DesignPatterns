using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasePizza();

            IPizza pizzaWithTomato = new TomatoTopping(pizza);
            IPizza pizzaWithTomatoAndPineapple = new PineaappleTopping(pizzaWithTomato);

            Console.WriteLine(pizzaWithTomatoAndPineapple.GetDetails());
            Console.WriteLine(pizzaWithTomatoAndPineapple.GetPrice());

            IPizza myfavoritePizza = new HalfPrice(new TomatoTopping(new CheeseTopping(new OliveTopping(new BasePizza()))));

            Console.WriteLine("My favorite pizza is: " + myfavoritePizza.GetDetails() + " and the price is: " + myfavoritePizza.GetPrice());
        }
    }
}
