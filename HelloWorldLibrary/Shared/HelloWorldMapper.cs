using HelloWorldLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLibrary.Shared
{
    public class HelloWorldMapper : IHelloWorldMapper
    {
        public Data StringToData(string s)
        {
            return new Data { stringData = s };
        }
    }
}
