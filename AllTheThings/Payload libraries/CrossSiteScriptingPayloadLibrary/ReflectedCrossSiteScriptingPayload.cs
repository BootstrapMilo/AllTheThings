namespace AllTheThings.PayloadLibrary.CrossSiteScriptingPayloadLibrary
{
    #region references
    // Project
    using Library42;
    #endregion

    public class ReflectedCrossSiteScriptingPayload : IPayload
    {
        public string payloadElement { get; set; }
        public string payloadEvent { get; set; }
        public string payloadFunction { get; set; }
        public string target { get; set; }
        public string tag { get; set; }
     }
}
