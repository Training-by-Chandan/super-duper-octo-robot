using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Services;

namespace Octo.ECom.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return RedirectToAction("Error", "Home");
            }
            ViewBag.Categories = new SelectList(categoryService.GetAll(), "Id", "Name", category.CategoryId);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryViewModel model)
        {
            ViewBag.Categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                var res = categoryService.Edit(model);
                if (res.Item1)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return RedirectToAction("Error", "Home");
            }
            categoryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}