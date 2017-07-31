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
            var xssLib = new ReflectedCrossSiteScriptingPayloadLibrary();
            var payloads = xssLib.RetriveAllPayloads();
            Console.ReadLine();
        }
    }
}
