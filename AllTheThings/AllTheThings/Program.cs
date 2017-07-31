using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllTheThings.Helpers;

namespace AllTheThings
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            IHttpRequester _httpRequester = new HttpRequester();
            Console.WriteLine("Hello crul world!");

            Console.ReadLine();

            string url = args[0];

            string content = "<sript>alert(1)</script>";

            var res = _httpRequester.MakeRequestAsync(url, content);


        }
    }
}
