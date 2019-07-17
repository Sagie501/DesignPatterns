using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public CustomerProxy(FlightSystemFacade flightSystemFacade) : base(flightSystemFacade)
        {
        }

        public void BuyTicket()
        {
            flightSystemFacade.BuyTicket();
        }

        public string ShowMyTickets()
        {
            return flightSystemFacade.ShowMyTickets();
        }
    }
}
