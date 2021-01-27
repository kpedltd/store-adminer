using System.Net.Http;
using System.Threading.Tasks;

namespace StoreAdminer.Data
{
    public class Request
    {
        public enum HttpMethod { GET, POST }

        private readonly HttpClient _httpClient;

        public string Url { get; set; }

        public HttpMethod Method { get; set; }

        public HttpContent Content { get; set; }

        public Request(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public static Request Get(HttpClient httpClient, string url)
        {
            return new Request(httpClient)
            {
                Method = HttpMethod.GET,
                Url = url
            };
        }

        public static Request Post(HttpClient httpClient, string url, HttpContent content = null)
        {
            return new Request(httpClient)
            {
                Method = HttpMethod.POST,
                Url = url,
                Content = content
            };
        }

        public async Task<HttpResponseMessage> Invoke()
        {
            HttpResponseMessage response;
            if (Method == HttpMethod.GET)
            {
                response = await _httpClient.GetAsync(Url);
            }
            else
            {
                response = await _httpClient.PostAsync(Url, Content);
            }
            return response;
        }
    }
}