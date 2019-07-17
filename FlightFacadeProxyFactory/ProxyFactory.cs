using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public class ProxyFactory
    {
        public ClientProxy Login(string userName, string password)
        {
            if (userName == "customer" && password == "customer")
            {
                return new CustomerProxy(new FlightSystemFacade(new FlightDAO()));
            }
            if (userName == "compnay" && password == "compnay")
            {
                return new CompanyProxy(new FlightSystemFacade(new FlightDAO()));
            }
            if (userName == "admin" && password == "admin")
            {
                return new AdminProxy(new FlightSystemFacade(new FlightDAO()));
            }

            throw new Exception("Wrong username or password");
        }
    }
}
