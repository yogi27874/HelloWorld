using System;
using HelloWorldLibrary.Model;
using HelloWorldLibrary.Shared;
using HelloWorldLibrary.Services;
using RestSharp;

namespace HelloWorldConsoleApp.Service
{
    public class HelloWorldService : IHelloWorldService
    {
        private readonly IAppSettings appSettings;
        private readonly IRestClient restClient;
        private readonly IRestRequest restRequest;
        private readonly IUri uriService;
        public HelloWorldService(IAppSettings appSettings,IRestClient restClient,IRestRequest restRequest,IUri uri)
        {
            this.restClient = restClient;
            this.restRequest = restRequest;
            this.appSettings = appSettings;
            uriService = uri;
        }

        public Data GetData()
        {
            Data data = null;
            restClient.BaseUrl = uriService.GetUri(appSettings.Get(AppKeys.ApiURL));
            restRequest.Resource = "data";
            restRequest.Method = Method.GET;
            restRequest.Parameters.Clear();

            var dataResponse = restClient.Execute<Data>(restRequest);
            if(dataResponse != null)
            {
                data = dataResponse.Data;
            }
            else
            {
                Console.WriteLine("Response from webservice is null");
            }
            return data;
        }

    }
}
