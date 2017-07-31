using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllTheThings.Helpers;
using AllTheThings.PayloadLibrary.CrossSiteScriptingPayloadLibrary;

namespace AllTheThings
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var expoite = new ReflectedCrossSiteScriptingPayload()
            {
                
            };

            FileSerializer<ReflectedCrossSiteScriptingPayload> fs = new FileSerializer<ReflectedCrossSiteScriptingPayload>();

            fs.SerializeToDisk(expoite, "TestFile");

            ReflectedCrossSiteScriptingPayload loadedExpoite = fs.GetFromDisk(@"C:\Exploits\TestFile.json");

            Console.WriteLine(loadedExpoite.Payload);
            Console.ReadLine();
        }
    }
}
