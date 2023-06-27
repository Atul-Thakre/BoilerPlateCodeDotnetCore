using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAppWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpPost]
        public ActionResult BookCourse()
        {

            return Ok();
        }


        public ActionResult CancelCourse()
        {

        }

    }
}
