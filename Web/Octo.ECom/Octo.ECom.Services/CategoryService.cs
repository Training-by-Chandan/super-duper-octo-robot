using Octo.ECom.Models.Models;
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
        (bool, string) Create(CategoryViewModel model);

        (bool, string) Delete(int id);

        (bool, string) Edit(CategoryViewModel model);

        List<CategoryViewModel> GetAll();

        CategoryViewModel? GetById(int id);
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository category;
        private readonly IEmailService emailService;

        public CategoryService(
            ICategoryRepository category,
            IEmailService emailService
            )
        {
            this.category = category;
            this.emailService = emailService;
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

        public CategoryViewModel? GetById(int id)
        {
            var cat = category.GetById(id);
            if (cat == null)
                return null;

            var catVm = new CategoryViewModel()
            {
                Id = cat.Id,
                CategoryId = cat.CategoryId,
                Description = cat.Description,
                Name = cat.Name,
                ParentCategoryName = cat.ParentCategory == null ? "" : cat.ParentCategory.Name
            };
            return catVm;
        }

        public (bool, string) Create(CategoryViewModel model)
        {
            try
            {
                var existing = category.GetAll().FirstOrDefault(p => p.Name == model.Name);
                if (existing != null)
                {
                    return (false, "Record with that name already exists");
                }
                else
                {
                    var cat = new Category()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        CategoryId = model.CategoryId
                    };

                    return category.Create(cat);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(CategoryViewModel model)
        {
            try
            {
                var existing = category.GetById(model.Id);
                if (existing == null)
                {
                    return (false, "Record does not exists");
                }
                else
                {
                    existing.Name = model.Name;
                    existing.Description = model.Description;
                    existing.CategoryId = model.CategoryId;

                    return category.Edit(existing);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = category.GetById(id);
                if (existing == null)
                {
                    return (false, "Record does not exists");
                }
                else
                {
                    var res = category.Delete(existing);
                    if (res.Item1)
                    {
                        sendEmail();
                    }
                    return res;
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        private void sendEmail()
        {
            //prepare body, subject etc
            string body = "Category deleted" + "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.";
            string subject = "category deleted";
            string receipent = "bishal@gmail.com";
            emailService.SendEmail(receipent: receipent, subject: subject, body: body);
        }
    }
}