using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsoleApp.Service;
using HelloWorldLibrary.Services;


namespace HelloWorldConsoleApp.App
{
    public class HelloWorldConsoleApp : IHelloWorldConsoleApp
    {
        private readonly IHelloWorldService helloWorldService;

        public HelloWorldConsoleApp(IHelloWorldService _helloWorldService)
        {
            this.helloWorldService = _helloWorldService;
        }

        public void Run(string[] arguments)
        {
            var data = helloWorldService.GetData();
        }
    }
}
