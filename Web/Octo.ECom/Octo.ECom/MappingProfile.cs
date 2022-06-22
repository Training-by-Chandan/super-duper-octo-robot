using AutoMapper;
using Octo.ECom.Models.Models;
using Octo.ECom.Models.ViewModels;

namespace Octo.ECom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().AfterMap((src, dest) =>
            {
                dest.ParentCategoryName = src.ParentCategory == null ? "" : src.ParentCategory.Name;
            });
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Product, ProductViewModel>().AfterMap((src, dest) =>
            {
                dest.CategoryName = src.Category == null ? "" : src.Category.Name;
            });
            CreateMap<ProductViewModel, Product>();
        }
    }
}