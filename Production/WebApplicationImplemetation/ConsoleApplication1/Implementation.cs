using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    /// <summary>
    /// This class implements the Generic GET and POST methods.
    /// </summary>
    internal class Implementation
    {
        Implementation obj;
        string url = string.Empty;
        string requestheader = string.Empty;
        public Implementation(string uri, string requestHeader)
        {
            this.url = uri;
            requestheader = requestHeader;
        }
        public async Task<IEnumerable<T>> Get<T>()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
            var response = await client.GetAsync(url);
            string res = await response.Content.ReadAsStringAsync();
            List<T> deserializedProduct = JsonConvert.DeserializeObject<List<T>>(res);
            return deserializedProduct;
        }
        public async Task<T> Get<T>(params string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
            foreach (string s in args)
            {
                url += "/" + s;
            }
            var response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();
            T res = JsonConvert.DeserializeObject<T>(result.Trim('[', ']'));
            return res;
        }
        public async Task<string> Post<T>(T obj)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(requestheader));
            HttpResponseMessage response = await client.PostAsJsonAsync(url, obj);
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
