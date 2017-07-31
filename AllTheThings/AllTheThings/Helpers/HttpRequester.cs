using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AllTheThings.Helpers
{
    public class HttpRequester : IRequester
    {
        public async Task<HttpResponseMessage> MakeRequestAsync(string uri, string content = null)
        {
            HttpClient client = new HttpClient();

            //Handle GetRequests
            if (string.IsNullOrEmpty(content))
            {
                return await client.GetAsync(uri);
            }

            //Handle PostRequests
            HttpContent httpCon = new StringContent(content);
            return await client.PostAsync(uri, httpCon);
        }
    }
}
