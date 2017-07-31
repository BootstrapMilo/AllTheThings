namespace AllTheThings.PayloadLibrary.CrossSiteScriptingPayloadLibrary
{
    using System;
    using System.Collections.Generic;
    #region references
    // Project
    using Library42;
    #endregion

    public class ReflectedCrossSiteScriptingPayload : IPayload
    {
        public string PayloadElement { get; set; }
        public string PayloadEvent { get; set; }
        public string PayloadFunction { get; set; }
        public List<string> Targets { get; set; }
        public List<string> Tags { get; set; }
    }
}
