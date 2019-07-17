using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public abstract class ClientProxy
    {
        protected FlightSystemFacade flightSystemFacade;

        protected ClientProxy(FlightSystemFacade flightSystemFacade)
        {
            this.flightSystemFacade = flightSystemFacade;
        }
    }
}
