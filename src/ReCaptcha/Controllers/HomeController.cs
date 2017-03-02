using Microsoft.AspNetCore.Mvc;

namespace ReCaptcha.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
