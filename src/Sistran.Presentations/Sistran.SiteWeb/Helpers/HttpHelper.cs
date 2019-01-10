using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Sistran.SiteWeb.Helpers
{
    public class HttpHelper
    {
        public static bool TryGetCookie(out string value, string key, HttpRequestBase request)
        {
            var token = request.Cookies.Get(key);

            if (token == null)
            {
                value = string.Empty;
                return false;
            }

            value = token.Value;
            return true;
        }

        public static void SetTokenCookie(string key, string value, HttpResponseBase response )
        {
            HttpCookie cookie = new HttpCookie(key);
            cookie.Value = value;

            response.SetCookie(cookie);
            response.Cookies.Add(cookie);
        }

        public static async Task<T> GetClient<T>(string url) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();

                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(content);
            }
        }

        public static async Task<T> PostClient<T>(string url) 
            where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.PostAsync(url, null);
                result.EnsureSuccessStatusCode();

                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(content);
            }
        }

        public static async Task<T> PostClient<T>(string url, string parameter) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.PostAsync(url, new StringContent(parameter));
                result.EnsureSuccessStatusCode();

                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(content);
            }
        }
    }
}