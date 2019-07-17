using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientProxy clientProxy = new ProxyFactory().Login("customer", "customer");
            CustomerProxy customerProxy = (CustomerProxy)clientProxy;

            customerProxy.BuyTicket();
            Console.WriteLine(customerProxy.ShowMyTickets());
        }
    }
}
