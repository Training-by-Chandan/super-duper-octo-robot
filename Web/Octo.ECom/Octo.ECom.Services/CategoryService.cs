using Octo.ECom.Models.ViewModels;
using Octo.ECom.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.ECom.Services
{
    public interface ICategoryService
    {
        List<CategoryViewModel> GetAll();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository category;

        public CategoryService(
            ICategoryRepository category
            )
        {
            this.category = category;
        }

        public List<CategoryViewModel> GetAll()
        {
            var data = category.GetAll();
            var ret = data.Select(p => new CategoryViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                CategoryId = p.CategoryId,
                Description = p.Description,
                ParentCategoryName = p.ParentCategory == null ? "" : p.ParentCategory.Name
            }).ToList();
            return ret;
        }
    }
}