using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Services;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Octo.ECom.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IHostingEnvironment env;

        public ProductController(
            IProductService productService,
            ICategoryService categoryService,
            IHostingEnvironment env
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.env = env;
        }

        public IActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model, IFormFile productPic)
        {
            ViewBag.categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                //file length is greater than 0
                if (productPic.Length > 0)
                {
                    //configure path
                    var extension = Path.GetExtension(productPic.FileName);
                    var newfileOnly = Guid.NewGuid().ToString() + extension;
                    var filePath = Path.Combine(env.WebRootPath, "uploads", "product", newfileOnly);

                    //save
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        productPic.CopyTo(stream);
                    }

                    //path => picture path in model
                    model.PicturePath = "/uploads/product/" + newfileOnly;
                    //product create
                    var res = productService.Create(model);
                    //respose return
                    if (res.Item1)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existing = productService.GetById(id);
            ViewBag.categories = new SelectList(categoryService.GetAll(), "Id", "Name", existing.CategoryId);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel model, IFormFile productPic)
        {
            ViewBag.categories = new SelectList(categoryService.GetAll(), "Id", "Name");
            if (ModelState.IsValid)
            {
                //file length is greater than 0
                if (productPic.Length > 0)
                {
                    //configure path
                    var extension = Path.GetExtension(productPic.FileName);
                    var newfileOnly = Guid.NewGuid().ToString() + extension;
                    var filePath = Path.Combine(env.WebRootPath, "uploads", "product", newfileOnly);

                    //save
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        productPic.CopyTo(stream);
                    }

                    //existing file delete
                    if (model.PicturePath != null)
                    {
                        var existing = Path.Combine(env.WebRootPath, model.PicturePath);
                        if (System.IO.File.Exists(existing))
                        {
                            System.IO.File.Delete(existing);
                        }
                    }

                    //path => picture path in model
                    model.PicturePath = "/uploads/product/" + newfileOnly;
                    //product create
                    var res = productService.Edit(model);
                    //respose return
                    if (res.Item1)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(model);
        }
    }
}