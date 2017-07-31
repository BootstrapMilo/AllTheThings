using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheThings.Library42.Manipulators
{
    public class AddEscapeChars : IManipulator
    {
        private readonly string _browser;
        public AddEscapeChars(string browser)
        {
            _browser = browser;
        }

        public string Manipulate(string s)
        {
            switch (_browser)
            {
                case "IExplorer":
                    return $"{s}0x20";
                case "Android":
                case "Opera":
                    return $"{s}0x3B";
                case "Chrome":
                case "FireFox":
                case "Safari":
                default:
                    return $"{s}0x2C";
            }
        }
    }
}
