using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.Repository;
using WindowsFormsApp.Viewmodel;

namespace WindowsFormsApp.Services
{
    public class CategoryServices
    {
        private CategoryRepository category = new CategoryRepository();
        public List<CategoryDDViewModel> GetCategoryDropDowns()
        {
            return category.GetAll().Select(p => new CategoryDDViewModel()
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();
        }
    }
}