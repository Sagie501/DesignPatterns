using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection numberCollection = new NumberCollection();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                numberCollection.Add(random.Next());
            }
            numberCollection.Sort();
            numberCollection.Add(random.Next());
            numberCollection.Sort();
        }
    }
}
