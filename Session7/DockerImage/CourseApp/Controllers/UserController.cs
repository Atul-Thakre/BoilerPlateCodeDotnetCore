using CourseApp.Models;
using CourseApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class UserController : Controller
    {
        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult CourseList()
        {
            List<Course> allCourse = _userService.GetAllCourses();
            return View(allCourse);




        }


    }
}
