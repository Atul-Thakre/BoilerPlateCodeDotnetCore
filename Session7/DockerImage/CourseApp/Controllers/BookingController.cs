using CourseApp.Models;
using CourseApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    [Route("booking")]
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public IActionResult Index()
        {
            List<Course> allCourses = _bookingService.GetAllCourses();



            TempData["Available_Courses"] = "Available Courses";
            return View(allCourses);

        }

        [HttpPost("book")]
        public IActionResult BookCourse(int courseId, int userId)
        {
            // Perform any necessary validation or processing before booking the course
            _bookingService.BookCourse(courseId, userId);

            // Redirect to a success page or return appropriate response
            return RedirectToAction("BookingSuccess");
        }

        [HttpPost("cancel/{bookingId}")]
        public IActionResult CancelCourse(int bookingId)
        {
            // Perform any necessary validation or processing before canceling the course
            _bookingService.CancelCourse(bookingId);

            // Redirect to a success page or return appropriate response
            return RedirectToAction("CancellationSuccess");
        }

        [HttpGet("success")]
        public IActionResult BookingSuccess()
        {
            // Show the booking success page
            return View();
        }

        [HttpGet("success/cancel")]
        public IActionResult CancellationSuccess()
        {
            // Show the cancellation success page
            return View();
        }
    }
}
