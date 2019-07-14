using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_20190714
{
    /// <summary>
    /// This is the class made for the singleton design pattern. I made this for fun. 
    /// <para>
    /// Toaster is the nickname for a loading animation. 
    /// </para>
    /// </summary>
    class Singleton
    {
        private static Singleton instance;

        private static readonly object key = new object();

        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            if (null != instance)
                return instance;
            lock (key)
            {
                if (null == instance)
                    instance = new Singleton();
            }
            return instance;
        }

        public void printCurrentTime()
        {
            Console.WriteLine("The time now is: " + DateTime.Now.ToString("HH:mm:ss tt"));
        }
    }
}
