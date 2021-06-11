using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
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
        public async Task<dynamic> send_file(string upload_url, string filename, string content_type, string file_to_upload)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.AllowAutoRedirect = false;
            using (HttpClient client = new HttpClient(handler))
            {
                MultipartFormDataContent step2content = new MultipartFormDataContent();
                FileInfo fi = new FileInfo(file_to_upload);

                // Add upload_params to HttpContent:
                step2content.Add(new StringContent(filename), "filename");
                step2content.Add(new StringContent(content_type), "content_type");

                // Add file content to HttpContent:
                FileStream fs = fi.OpenRead();
                byte[] file_bytes = new byte[fi.Length];
                int num_bytes = fs.Read(file_bytes, 0, file_bytes.Length);
                fs.Close();

                step2content.Add(new ByteArrayContent(file_bytes), "file");

                HttpResponseMessage step2response = await client.PostAsync(upload_url, step2content);
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
