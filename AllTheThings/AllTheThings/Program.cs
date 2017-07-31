using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllTheThings.Helpers;
using AllTheThings.Library42.Manipulators;
using AllTheThings.PayloadLibrary.CrossSiteScriptingPayloadLibrary;

namespace AllTheThings
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string s = "This is a test";
            Console.WriteLine(s);
            var uni = new StringToHexReprecentation();

            Console.WriteLine(uni.Manipulate(s));
            Console.ReadLine();
        }
    }
}
