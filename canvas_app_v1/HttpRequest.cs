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

        // Method to perform GET requests to retrieve items:
        public static async Task<dynamic> get_item_at_url(string base_url, string access_token, string url_command)
        {
            string return_val = string.Empty;

            using (HttpResponseMessage response = await http_get(base_url, access_token, url_command))
            {
                return_val = await response.Content.ReadAsStringAsync();
                Console.WriteLine("String from response: " + return_val);

                if (!response.IsSuccessStatusCode || (return_val.Contains("errors") && return_val.Contains("message")))
                {
                    Console.WriteLine("Retrieval failed because: " + response.StatusCode + " " + response.ReasonPhrase + ".");
                    Console.WriteLine("Access Token: " + access_token);
                    Console.WriteLine("Url : " + base_url + url_command);
                    throw new HttpRequestException(return_val);
                }
            }

            Console.WriteLine("Return_val after function completion: " + return_val);
            return JsonConvert.DeserializeObject(return_val);
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

        // Method to perform PUT requests to accomplish tasks: (may implement methods for custom
        // PUT requests at some point)
        public static async Task<dynamic> put_item_at_url(string base_url, string access_token, string url_command)
        {
            string return_val = string.Empty;

            using (HttpResponseMessage response = await http_put(base_url, access_token, url_command, null))
            {
                return_val = await response.Content.ReadAsStringAsync();
                Console.WriteLine("String from response: " + return_val);

                if (!response.IsSuccessStatusCode || (return_val.Contains("errors") && return_val.Contains("message")))
                {
                    Console.WriteLine("Retrieval failed because: " + response.StatusCode + " " + response.ReasonPhrase + ".");
                    Console.WriteLine("Access Token: " + access_token);
                    Console.WriteLine("Url : " + base_url + url_command);
                    throw new HttpRequestException(return_val);
                }
            }

            Console.WriteLine("Return_val after function completion: " + return_val);
            return JsonConvert.DeserializeObject(return_val);
        }
    }
}
