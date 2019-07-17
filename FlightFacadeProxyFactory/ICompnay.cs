using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightFacadeProxyFactory
{
    public interface ICompnay
    {
        void CreateFlight();

        void CancelFlight();
    }
}
