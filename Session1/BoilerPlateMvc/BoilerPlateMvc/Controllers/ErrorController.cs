using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BoilerPlateMvc.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public IActionResult HttpStatusCodeHandeler(int StatusCode)
        {
            var StatusCoderesult=HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (StatusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resources you are asking could not be found";

                    break;
            }

            return View("NotFound");
        }
    }
}
