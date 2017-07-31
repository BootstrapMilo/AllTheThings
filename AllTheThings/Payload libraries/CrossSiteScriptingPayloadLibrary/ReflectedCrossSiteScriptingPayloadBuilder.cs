namespace AllTheThings.PayloadLibrary.CrossSiteScriptingPayloadLibrary
{
    #region references
    // Microsoft
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    // Project
    using CrossSiteScriptingPayloadLibrary;
    using AllTheThings.Helpers;    
    #endregion

    public class ReflectedCrossSiteScriptingPayloadLibrary : ICrossSiteScriptingPayloadBuilder
    {
        public List<ReflectedCrossSiteScriptingPayload> RetriveAllPayloads()
        {
            #region Initialise
            var payloads = new List<ReflectedCrossSiteScriptingPayload>();
            var fileSerializer = new FileSerializer<ReflectedCrossSiteScriptingPayload>();
            #endregion

            #region RetrivePayloadsFromFile
            List<string> paths = RetriveListOfCrossSiteScriptingPayloadFilePaths();
            foreach (var path in paths)
            {
                payloads.Add(fileSerializer.GetFromDisk(path));
            }
            #endregion
            
            return payloads;
        }

        public List<ReflectedCrossSiteScriptingPayload> RetriveAllPayloadsOfTag(string[] tags)
        {
            throw new NotImplementedException();
            var payloads = new List<ReflectedCrossSiteScriptingPayload>();
            return payloads;
        }

        public ReflectedCrossSiteScriptingPayload CreatePayload(string payloadElement, string payloadEvent, string payloadFunction, List<string> targets, List<string> tags)
        {
            return new ReflectedCrossSiteScriptingPayload()
            {
                PayloadElement = payloadElement,
                PayloadEvent = payloadEvent,
                PayloadFunction = payloadFunction,
                Targets = targets,
                Tags = tags
            };
        }

        public void StorePayload(ReflectedCrossSiteScriptingPayload payload)
        {
            //todo move directory to config
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
            var directory = projectPath + @"\Data\Payloads\";
            var fileSerializer = new FileSerializer<ReflectedCrossSiteScriptingPayload>();
            fileSerializer.SerializeToDisk(payload, $"{directory}xss-{Guid.NewGuid()}");
        }

        private List<string> RetriveListOfCrossSiteScriptingPayloadFilePaths()
        {
            //todo move directory to config
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
            var directory = projectPath+@"\Data\Payloads\";
            var files = Directory.EnumerateFiles(directory, "*xss*", SearchOption.AllDirectories).ToList();
            return files;
        }
    }
}
