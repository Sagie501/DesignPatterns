using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public interface ICustomer
    {
        void BuyTicket();

        string ShowMyTickets();
    }
}
