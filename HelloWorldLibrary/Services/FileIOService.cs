using System;
using System.IO;

namespace HelloWorldLibrary.Services
{
    public class FileIOService : IFileIOService
    {
        public string ReadFile(string path)
        {
            string filedata = null;
            try
            {
                using (var reader = new StreamReader(path))
                {
                    filedata = reader.ReadToEnd();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("There was problem reading data."+ e.InnerException);
            }
            return filedata;
        }
    }
}
