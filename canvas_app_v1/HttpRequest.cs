using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace canvas_app_v1
{
    static class HttpRequest
    {
        // Method to perform GET requests:
        public static async Task<HttpResponseMessage> http_get(string base_url, string access_token, string url_command)
        {
            HttpResponseMessage response = null;

            HttpClientHandler handler = new HttpClientHandler();
            handler.AllowAutoRedirect = false;
            using (HttpClient client = new HttpClient(handler, true))
            {
                client.BaseAddress = new Uri(base_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

                response = await client.GetAsync(url_command);
            }

            Console.WriteLine("Response from http_get: " + response);
            return response;
        }

        // Method to perform PUT requests:
        public static async Task<HttpResponseMessage> http_put(string base_url, string access_token, string url_command, HttpContent content)
        {
            HttpResponseMessage response = null;

            HttpClientHandler handler = new HttpClientHandler();
            handler.AllowAutoRedirect = false;
            using (HttpClient client = new HttpClient(handler, true))
            {
                client.BaseAddress = new Uri(base_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

                response = await client.PutAsync(url_command, content);
            }

            Console.WriteLine("Response from http_put: " + response);
            return response;
        }
    }
}
