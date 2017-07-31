using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllTheThings.Helpers;
using AllTheThings.CrossSiteScriptingExploitLibrary;

namespace AllTheThings
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var expoite = new ReflectedCrossSiteScriptingExploit()
            {
                Payload = "Test PayLoad"
            };

            FileSerializer<ReflectedCrossSiteScriptingExploit> fs = new FileSerializer<ReflectedCrossSiteScriptingExploit>();

            fs.SerializeToDisk(expoite, "TestFile");

            ReflectedCrossSiteScriptingExploit loadedExpoite = fs.GetFromDisk(@"C:\Exploits\TestFile.json");

            Console.WriteLine(loadedExpoite.Payload);
            Console.ReadLine();
        }
    }
}
