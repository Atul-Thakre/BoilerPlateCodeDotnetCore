using CourseAppMvcFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CourseAppMvcFrontEnd.Controllers
{
    public class CourseController : Controller
    {
        private List<GetCoursesVM>? allCourses;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetAllCourses()
        {
            //create a List To hold Values sent from API
           // List<GetCoursesVM> allCourses = new List<GetCoursesVM>();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync("https://localhost:7232/api/Course/GetAllCourses"))
                {

                    string data = response.Content.ReadAsStringAsync().Result;
                    allCourses = JsonConvert.DeserializeObject<List<GetCoursesVM>>(data);
                }
                return View(allCourses);
            }
        }
            // [HttpGet]
            public async Task<ActionResult> GetCourseById(int id)
            {
            GetCourseDetailsDto course = new GetCourseDetailsDto();
                using (var httpclient = new HttpClient())
                {
                    using (var response = await httpclient.GetAsync("https://localhost:7232/api/Course/GetCourseById?id=" + id))
                    {
                    
                        string data = response.Content.ReadAsStringAsync().Result;
                        course = JsonConvert.DeserializeObject<GetCourseDetailsDto>(data);
                    }
                    return View(course);
                }

            }


        [HttpGet]
        public async Task<ActionResult> AddCourse()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCourse(AddCourseDto addCourseDto)
        {
            AddCourseDto course = new AddCourseDto();
            using (var httpclient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(addCourseDto), Encoding.UTF8, "application/json");
                using (var response = await httpclient.PostAsync("https://localhost:7232/api/Course/AddCourse", content))
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    course = JsonConvert.DeserializeObject<AddCourseDto>(data);
                }
                return View(course);
            }

        }


    }
}
