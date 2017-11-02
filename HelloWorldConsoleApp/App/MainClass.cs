using LightInject;
using RestSharp;
using HelloWorldConsoleApp.Service;
using HelloWorldLibrary.Services;
using HelloWorldLibrary.Shared;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.App
{
    public class MainClass
    {
        public static void Main(string []args)
        {
            using (var container = new ServiceContainer())
            {
                container.Register<IHelloWorldConsoleApp, HelloWorldConsoleApp>();
                container.Register<IHelloWorldService, HelloWorldService>();
                container.Register<IAppSettings, ConfigForAppSettings>();
                container.Register<IUri, SystemUri>();
                container.RegisterInstance(typeof(IRestClient), new RestClient());
                container.RegisterInstance(typeof(IRestRequest), new RestRequest());
                container.GetInstance<IHelloWorldConsoleApp>().Run(args);
            }
        }
    }
}
