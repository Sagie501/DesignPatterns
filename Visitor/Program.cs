using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Console.WriteLine(vodka);

            Perfume perfume = new Perfume(300);
            Console.WriteLine(perfume);

            IVisitor endOfYearTax = new EndOfYearTax();
            IVisitor oneShekelSale = new OneShekelSale();

            Console.WriteLine($"Vodka price after end of year tax = {vodka.Accept(endOfYearTax)}");
            Console.WriteLine($"Perfume price after one shekel sale = {perfume.Accept(oneShekelSale)}");
        }
    }
}
