using Microsoft.AspNetCore.Mvc;

namespace Plana.Api.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]

        public IActionResult HttpStatusHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErroMessage = "Sorry, the resource you requested could not be found";
                    break;
            }
            return View();
        }
    }
}
