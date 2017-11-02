using HelloWorldLibrary.Model;
using HelloWorldLibrary.Services;
using HelloWorldLibrary.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLibrary.Services
{
    public class HelloWorldDataService : IDataService
    {
        private readonly IAppSettings appSettings;        
        private readonly IFileIOService fileIOService;
        private readonly IHelloWorldMapper helloWorldMapper;
        

        public HelloWorldDataService(IAppSettings appSettings, IFileIOService fileIOService,IHelloWorldMapper helloWorldMapper)
        {
            this.appSettings = appSettings;
            this.fileIOService = fileIOService;
            this.helloWorldMapper = helloWorldMapper;
            
        }

        public Data GetData()
        {
            var path = this.appSettings.Get(AppKeys.DataFileKey);
            if(string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Data file name cannot be null");
            }
            var rawdata = fileIOService.ReadFile(path);

            return helloWorldMapper.StringToData(rawdata);
        }
    }
}
