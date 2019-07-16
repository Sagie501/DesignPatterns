using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Not touchable
    public class ClientData
    {
        protected string name;
        protected int id;

        public ClientData(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
