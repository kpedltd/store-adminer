using StoreAdminer.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdminer.Data {
    public class CallFactoryProvider {

        private readonly HttpClient _httpClient;

        private static CallFactoryProvider _instance;

        private readonly CookieProvider _cookieProvider = CookieProvider.GetInstance();
        private readonly List<Interceptor> _interceptors = new List<Interceptor>();

        public static CallFactoryProvider GetInstance() {
            return _instance ?? (_instance = new CallFactoryProvider());
        }

        private CallFactoryProvider() {
            var httpClientHandler = new HttpClientHandler {
                AllowAutoRedirect = true,
                UseCookies = true,
                CookieContainer = _cookieProvider.GetCookieContainer()
            };

            _httpClient = new HttpClient(httpClientHandler) {
                BaseAddress = new Uri(Config.HOST)
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.Timeout = TimeSpan.FromSeconds(5);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

        }

        private void OnApplicationExit(object sender, EventArgs e) {
            _cookieProvider.SaveCookieContainer();
        }

        public void AddInterceptor(Interceptor interceptor) {
            _interceptors.Add(interceptor);
        }
        
        public void RemoveInterceptor(Interceptor interceptor) {
            _interceptors.Remove(interceptor);
        }

        public Dictionary<string, Cookie> GetCookies() {
            return _cookieProvider.GetCookies();
        }

        public async Task<T> GetRequestAsync<T>(string path, NameValueCollection query = null) {
            return (await GetRequestAsync(path, query)).Deserialize<T>();
        }

        public async Task<string> GetRequestAsync(string path, NameValueCollection query = null) {

            var url = _httpClient.BaseAddress + path + query?.ToQueryString();
            return await SendRequest(Request.Get(_httpClient, url));
        }

        public  async Task<T> PostRequestAsync<T>(
            string path, 
            HttpContent content) {

            return (await PostRequestAsync(path, content)).Deserialize<T>();
        }

        public  async Task<string> PostRequestAsync(
            string path, 
            HttpContent content) {

            var url = _httpClient.BaseAddress + path;
            return await SendRequest(Request.Post(_httpClient, url, content));
        }

        public  async Task<T> PostRequestAsync<T>(
            string path, 
            NameValueCollection query = null,
            NameValueCollection body = null) {

            return (await PostRequestAsync(path, query, body)).Deserialize<T>();
        }

        public async Task<string> PostRequestAsync(
            string path,
            NameValueCollection query = null,
            NameValueCollection body = null) {

            var httpContent = body.ToJsonContent();
            var url = _httpClient.BaseAddress + path + query?.ToQueryString();
            return await SendRequest(Request.Post(_httpClient, url, httpContent));
        }

        private async Task<string> SendRequest(Request request) {
            HttpResponseMessage response;
            if (_interceptors.Count > 0) {
                var chain = new RealInterceptorChain(request, 0, _interceptors);
                response = await chain.Proceed(request);
            } else {
                response = await request.Invoke();
            }

            _cookieProvider.SaveCookieContainer();

            var json = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != HttpStatusCode.OK) {
                var message = json.Deserialize<ErrorResponse>().Message;
                throw new HttpError(response.StatusCode, message);
            }

            return json;
        }

    }
}
