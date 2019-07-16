using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClinetData webClinetData = new WebClinetData("MyClient", 1, "190.120.0.1", true);

            storeClient(new AdapterWebToNonWeb(), webClinetData);
        }

        // non mutable
        private static void storeClient(IDBWebData dBWebData, WebClinetData webClinetData)
        {
            dBWebData.Store(webClinetData);
        }
    }
}
