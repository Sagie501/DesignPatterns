using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClinetData
    {
        public string name;
        public int id;
        protected string ip;
        protected bool ssl;

        public WebClinetData(string name, int id, string ip, bool ssl)
        {
            this.name = name;
            this.id = id;
            this.ip = ip;
            this.ssl = ssl;
        }
    }
}
