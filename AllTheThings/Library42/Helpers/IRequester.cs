using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AllTheThings.Helpers
{
    public interface IRequester
    {
        Task<HttpResponseMessage> MakeRequestAsync(string uri, string content = null);
    }
}
