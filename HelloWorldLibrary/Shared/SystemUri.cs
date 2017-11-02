using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLibrary.Shared
{
    public class SystemUri : IUri
    {
        public Uri GetUri(string uriString)
        {
            return new Uri(uriString);
        }
    }
}
