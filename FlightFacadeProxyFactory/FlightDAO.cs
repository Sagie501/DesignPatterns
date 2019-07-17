using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class FlightDAO
    {
        public void InsertTicket()
        {
            Console.WriteLine("Buying a ticket");
        }

        public string GetTickets()
        {
            return "Here is your tickets";
        }

        public void InsertFlight()
        {
            Console.WriteLine("Create new flight");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Remove the flight");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Create new customer");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Create new company");
        }
    }
}
