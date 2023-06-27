using CourseApp.Models;
using CourseApp.Repository;
using CourseApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Controllers
{
    //[Route("[Controller]/[Action]")]
    public class CourseController : Controller
    {
        readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        { 
            _courseService = courseService;
        }

       
        [Route("Course/Index")]
        public IActionResult Index()
        {
            List<Course> allProducts = _courseService.GetAllCourses();

            
         
            TempData["Available_Courses"]="Available Courses";
            return View(allProducts);

        }


        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }
        
        
        //get data from form (view)
        //Model Binding

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            //bool addProductStatus = _courseService.AddCourse(course);
            //TempData["successMsg"] = "Product Added Successfully.....!";
            try 
            {  
                
                var addCourseStatus = _courseService.AddCourse(course);
                return RedirectToAction("Index");
            }   
            catch (Exception CourseAlCourseAlreadyExistsException)
            {
                TempData["ErrorMessage"] = CourseAlCourseAlreadyExistsException.Message;
                return RedirectToAction("Error");
            }
        }
        [HttpPost]
        public ActionResult Error()
        {
            string errorMessage = TempData["ErrorMessage"] as string;
            ViewBag.ErrorMessage = errorMessage;

            return View();
        }
      
        
        [HttpGet]
        //[Route("Course/EditCourse")]
        public ActionResult EditCourse(int id)
        {
            var course = _courseService.GetById(id);
            return View(course);
        }

        [HttpPost]
        public ActionResult EditCourse(Course course)
        {
            _courseService.EditCourse1(course);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult DeleteCourse(int id)
        {
            var course = _courseService.GetById(id);
            return View(course);
        }

        [HttpPost]
        public ActionResult DeleteCourse(Course course)
        {
            _courseService.DeleteCourseById(course.CourseId);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult ShowDetailsOfCourse(int id)
        {
            var course = _courseService.GetById(id);
            return View(course);
        }

        [HttpPost]
        public ActionResult ShowDetailsOfCourse(Course course)
        {
            _courseService.ShowDetailsOfCourse(course.CourseId);
            return RedirectToAction("index");
        }




    }
}
