using Microsoft.AspNetCore.Mvc;
using Octo.ECom.Services;

namespace Octo.ECom.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(
            IProductService productService,
            ICategoryService categoryService
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }
    }
}