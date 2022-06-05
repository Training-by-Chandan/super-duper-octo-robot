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
            return View();
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
    }
}