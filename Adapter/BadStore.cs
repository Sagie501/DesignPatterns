using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBWebData
    {
        public void Store(WebClinetData webClinetData)
        {
            Console.WriteLine("Stroing badly web client data");
        }
    }
}
