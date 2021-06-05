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

        private async void confirm_file_upload(string location, string token)
        {
            using (HttpClient client = new HttpClient())
            {

            }
        }
    }
}
