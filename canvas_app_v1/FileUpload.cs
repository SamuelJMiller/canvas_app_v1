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
    class FileUpload
    {
        private const string BASE_URL = "https://centralia.instructure.com/api/v1/"; // All API access starts here
        private const string TEST_TOKEN = "9~Uo3aHRPFGxOZ3XJJXh97uYceOhwk8z4XQKkSCZylTCsJOqHHHIp8aA8BBUbDVRm9"; // User-generated API token

        // Uploads files to Canvas
        public void upload_file_to_course(string filename, string course_id)
        {

        }

        // Step one of the file upload process: initialize file location
        public async Task<dynamic> init_file_upload(string filename)
        {
            // No deserialize needed; method does it for me
            dynamic response = await HttpRequest.get_post_response(BASE_URL, TEST_TOKEN, "courses/2060237/files" +
                "?name=" + filename);

            return response;
        }

        // Step two of the file upload process: send the data to the specific upload_url
        public async Task<dynamic> send_file(string upload_url)
        {
            using (HttpClient client = new HttpClient())
            {
                string final_url = upload_url + "?filename=testfile.txt&content_type=text/plain&file=@heyhey";

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TEST_TOKEN);
                HttpResponseMessage step2response = await client.PostAsync(final_url, null);

                string result_string = await step2response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject(result_string);
            }
        }

        // Step three of the file upload process: confirm that the file exists on the Canvas instance
        public async Task<dynamic> confirm_file_upload(string location)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TEST_TOKEN);
                HttpResponseMessage step3response = await client.GetAsync(location);

                string result_string = await step3response.Content.ReadAsStringAsync();

                if (!step3response.IsSuccessStatusCode)
                {
                    
                }

                return JsonConvert.DeserializeObject(result_string);
            }
        }
    }
}
