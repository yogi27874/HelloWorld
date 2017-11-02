using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldLibrary.Model;
using HelloWorldLibrary.Services;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class DataController : ApiController
    {
        private readonly IDataService dataService;
        public DataController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public Data Get()
        {
            return dataService.GetData();
        }
    }
}
