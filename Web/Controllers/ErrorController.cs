using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            if (statusCode == 403 || statusCode == 404)
            {
                return View($"{statusCode}");
            }

            return View("500");
        }

        [Route("Error/500")]
        public IActionResult GlobalError()
        {
            return View("500");
        }
    }
}
