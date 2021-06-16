using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvas_app_v1
{
    // A class to use HttpRequest to get specific things from Canvas
    static class HttpUtilities
    {
        public static async Task<dynamic> get_teacher_courses(string base_url, string token)
        {
            return await HttpRequest.get_get_response(base_url, token, "courses?enrollment_type=teacher");
        }
    }
}
