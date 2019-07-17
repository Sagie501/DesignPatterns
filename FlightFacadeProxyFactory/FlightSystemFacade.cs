using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class FlightSystemFacade : ICustomer, ICompnay, IAdmin
    {
        FlightDAO flightDAO;

        public FlightSystemFacade(FlightDAO flightDAO)
        {
            this.flightDAO = flightDAO;
        }

        public void BuyTicket()
        {
            flightDAO.InsertTicket();
        }

        public void CancelFlight()
        {
            flightDAO.RemoveFlight();
        }

        public void CreateCompany()
        {
            flightDAO.InsertCompany();
        }

        public void CreateCustomer()
        {
            flightDAO.InsertCustomer();
        }

        public void CreateFlight()
        {
            flightDAO.InsertFlight();
        }

        public string ShowMyTickets()
        {
            return flightDAO.GetTickets();
        }
    }
}
