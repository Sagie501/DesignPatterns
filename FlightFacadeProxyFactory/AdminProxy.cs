using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public AdminProxy(FlightSystemFacade flightSystemFacade) : base(flightSystemFacade)
        {
        }

        public void CreateCompany()
        {
            flightSystemFacade.CreateCompany();
        }

        public void CreateCustomer()
        {
            flightSystemFacade.CreateCustomer();
        }
    }
}
