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
        // Get courses the instructor is teaching:
        public static async Task<dynamic> get_teacher_courses(string base_url, string token)
        {
            return await HttpRequest.get_get_response(base_url, token, "courses?enrollment_type=teacher");
        }

        // Get pages from a specific course:
        public static async Task<dynamic> get_course_pages(string base_url, string token, string course_id)
        {
            return await HttpRequest.get_get_response(base_url, token, "courses/" + course_id + "/pages");
        }

        // Get single page:
        public static async Task<dynamic> get_single_page(string base_url, string token, string course_id, string page_url)
        {
            return await HttpRequest.get_get_response(base_url, token, "courses/" + course_id + "/pages/" + page_url);
        }

        // Update page:
        public static async Task<dynamic> update_page(string base_url, string token, string course_id, string page_url, string page_body)
        {
            return await HttpRequest.get_put_response(base_url, token, "courses/" + course_id + "/pages/" + page_url +
                "?wiki_page[body]=" + page_body);
        }

        // Get syllabus for a specific course:
        public static async Task<dynamic> get_course_syllabus(string base_url, string token, string course_id)
        {
            return await HttpRequest.get_get_response(base_url, token, "courses/" + course_id + "?include[]=syllabus_body");
        }
    }
}
