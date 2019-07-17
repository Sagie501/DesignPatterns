using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class CompanyProxy : ClientProxy, ICompnay
    {
        public CompanyProxy(FlightSystemFacade flightSystemFacade) : base(flightSystemFacade)
        {
        }

        public void CancelFlight()
        {
            flightSystemFacade.CancelFlight();
        }

        public void CreateFlight()
        {
            flightSystemFacade.CreateFlight();
        }
    }
}
