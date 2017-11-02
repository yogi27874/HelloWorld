using System.Configuration;

namespace HelloWorldLibrary.Services
{
    public class ConfigForAppSettings: IAppSettings
    {
        public string Get(string name)
        {
            return ConfigurationManager.AppSettings.Get(name);
        }
    }
}
