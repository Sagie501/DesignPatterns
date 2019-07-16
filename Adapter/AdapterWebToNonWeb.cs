using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterWebToNonWeb : IDBWebData
    {
        IDBData iDBData = new PerfectStore();
        public void Store(WebClinetData webClinetData)
        {
            iDBData.Store(new ClientData(webClinetData.name, webClinetData.id));
        }
    }
}
