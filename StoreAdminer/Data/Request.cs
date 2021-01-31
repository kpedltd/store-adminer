using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StoreAdminer.Data {
    public class Request {
        private enum HttpMethod { GET, POST }

        private readonly HttpClient _httpClient;

        public HttpRequestHeaders Headers => _httpClient.DefaultRequestHeaders;

        private string url { get; set; }
        private HttpMethod method { get; set; }
        private HttpContent content { get; set; }

        private Request(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public static Request Get(HttpClient httpClient, string url) {
            return new Request(httpClient) {
                method = HttpMethod.GET,
                url = url
            };
        }
        public static Request Post(HttpClient httpClient, string url, HttpContent content = null) {
            return new Request(httpClient) {
                method = HttpMethod.POST,
                url = url,
                content = content
            };
        }

        public async Task<HttpResponseMessage> Invoke() {
            HttpResponseMessage response;
            if (method == HttpMethod.GET) {
                response = await _httpClient.GetAsync(url);
            } else {
                response = await _httpClient.PostAsync(url, content);
            }
            return response;
        }

    }
}
