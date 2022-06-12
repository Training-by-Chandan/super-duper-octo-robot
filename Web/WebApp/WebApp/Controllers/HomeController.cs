using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cookie = Request.Cookies["name"];
            ViewBag.cookie = cookie;
            var data = GenerateDataForHomeIndex();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            var data = GenerateDummyData();
            return View(data);
        }

        public IActionResult SetCookies(string key, string value)
        {
            try
            {
                Response.Cookies.Append(key, value, new CookieOptions() { Expires = DateTime.Now.AddSeconds(60), Path = "/Home/Index" });
                HttpContext.Session.SetString(key, value);
                var data = GenerateDataForHomeIndex();
                return View("Index", data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static List<StudentViewModel> GenerateDummyData()
        {
            return new List<StudentViewModel>() {
                new StudentViewModel(){ Id=1,  Name="Bikrant", Email="bikrant@gmail.com"},
                new StudentViewModel(){ Id=2,  Name="Bishal", Email="bishal@gmail.com"},
                new StudentViewModel(){ Id=3,  Name="Shivraj", Email="shivraj@gmail.com"},
            };
        }

        private static HomeIndexViewModel GenerateDataForHomeIndex()
        {
            return new HomeIndexViewModel()
            {
                Boxes = new List<BoxInfoViewModel>()
                {
                    new BoxInfoViewModel(){ Number="160", Title="New Orders", BoxIcon= "ion-bag", BoxType="bg-info"},
                     new BoxInfoViewModel(){ Number="83%", Title="Bounce Rate", BoxIcon= "ion-stats-bars", BoxType="bg-success"},
                      new BoxInfoViewModel(){ Number="44", Title="User Registrations", BoxIcon= "ion-person-add", BoxType="bg-warning"},
                       new BoxInfoViewModel(){ Number="65", Title="Unique Visitors", BoxIcon= "ion-pie-graph", BoxType="bg-danger"},
                }
            };
        }
    }
}