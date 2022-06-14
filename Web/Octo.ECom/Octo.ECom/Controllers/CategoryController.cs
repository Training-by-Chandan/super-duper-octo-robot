using Microsoft.AspNetCore.Mvc;
using Octo.ECom.Services;

namespace Octo.ECom.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = categoryService.GetAll();
            return View(data);
        }
    }
}