using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace AllTheThings.Helpers
{
    public class FileSerializer<T>
    {

        public bool SerializeToDisk(T toSer, string path)
        {
            using(StreamWriter file = File.CreateText(path))
            {
                file.Write(JsonConvert.SerializeObject(toSer));
            }
            return File.Exists(path);
        }

        /// <summary>
        /// Returns parm uri as T.
        /// </summary>
        /// <param name="uri">absolut path to JSON reprecentation of an object of type T</param>
        /// <returns></returns>
        public T GetFromDisk(string uri)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(uri));
        }
    }
}
