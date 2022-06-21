using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Services;

namespace Octo.ECom.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(
            IUserService userService
            )
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AdminUserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = userService.CreateUser(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index", "Dashboard",new { area="Admin"});

                }
            }
            return View(model);
        }
    }
}