using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheThings.Library42.Manipulators
{
    public class StringRandomCapetalizer : IManipulator
    {
        public string Manipulate(string s)
        {
            string res = string.Empty;
            var r = new Random();
            foreach (var c in s.ToCharArray())
            {
                if (r.Next(100) >= 50)
                {
                    res += c;
                }
                else
                {
                    res += c.ToString().ToUpper();
                }
            }
            return res;
        }
    }
}
