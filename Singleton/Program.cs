using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_20190714
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            Singleton s3 = Singleton.getInstance();

            s1.printCurrentTime();
            s2.printCurrentTime();
            s3.printCurrentTime();
        }
    }
}
