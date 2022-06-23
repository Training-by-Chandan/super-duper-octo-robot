using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Services;

namespace Octo.ECom.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("get-all")]
        public List<CategoryViewModel> GetAll()
        {
            return categoryService.GetAll();
        }
    }
}