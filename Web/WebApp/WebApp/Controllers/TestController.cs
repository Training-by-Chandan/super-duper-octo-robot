using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult abc()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }
    }
}