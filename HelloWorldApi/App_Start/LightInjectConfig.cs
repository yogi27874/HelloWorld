using HelloWorldLibrary.Shared;
using HelloWorldLibrary.Services;
using System.Web.Http;
using LightInject;
namespace HelloWorldApi
{
    
    public static class LightInjectConfig
    {
        public static void Register(HttpConfiguration httpConfiguration)
        {
            var cont = new ServiceContainer();
            cont.RegisterApiControllers();
            cont.EnableWebApi(GlobalConfiguration.Configuration);
            cont.EnableMvc();
            cont.EnablePerWebRequestScope();
            RegisterServices(cont);
        }

        private static void RegisterServices(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IAppSettings, ConfigForAppSettings>();
            serviceRegistry.Register<IFileIOService, FileIOService>();
            serviceRegistry.Register<IDataService, HelloWorldDataService>();
            serviceRegistry.Register<IHelloWorldMapper, HelloWorldMapper>();
        }
    }
}