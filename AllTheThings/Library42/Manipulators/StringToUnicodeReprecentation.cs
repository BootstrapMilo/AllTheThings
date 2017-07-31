using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheThings.Library42.Manipulators
{
    public class StringToUnicodeReprecentation : IManipulator
    {
        public string Manipulate(string s)
        {
            string res = string.Empty;

            System.Text.UTF32Encoding encoding = new System.Text.UTF32Encoding();
            byte[] bytes = encoding.GetBytes(s);

            for (int i = 0; i < bytes.Length; i += sizeof(int))
            {
                res += $@"\u{BitConverter.ToInt32(bytes, i):X4}";
            }

            return res;
        }
    }
}
