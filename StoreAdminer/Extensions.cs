using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace StoreAdminer {
    static class Extensions {

        public static Dictionary<string, object> ToDictionary(this NameValueCollection nvc) {
            var result = new Dictionary<string, object>();
            foreach (string key in nvc.Keys) {
                result.Add(key, nvc[key]);
            }

            return result;
        }

        public static string ToQueryString(this NameValueCollection nvc) {
            StringBuilder sb = new StringBuilder("?");

            bool first = true;
            foreach (string key in nvc.AllKeys) {
                foreach (string value in nvc.GetValues(key)) {
                    if (!first) {
                        sb.Append("&");
                    }

                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));
                    first = false;
                }
            }

            return sb.ToString();
        }

        public static HttpContent ToJsonContent(this NameValueCollection nvc) {
            var bodyString = "";
            if (nvc != null) {
                bodyString = JsonConvert.SerializeObject(nvc.ToDictionary());
            }
            var httpContent = new StringContent(bodyString, Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpContent;
        }

        public static HttpContent ToJsonContent<T>(this T obj) {
            var httpContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpContent;
        }

        public static T Deserialize<T>(this string jsonString) {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static string GetOrNull(this string str) {
            return (str == null || str == "") ? null : str;
        }

    }
}
