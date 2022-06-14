using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Octo.ECom.Models.ViewModels;
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

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            ViewBag.Categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                var res = categoryService.Create(model);
                if (res.Item1)
                    return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}