using AutoMapper;
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
        private readonly IMapper mapper;

        public CategoryService(
            ICategoryRepository category,
            IEmailService emailService,
            IMapper mapper
            )
        {
            this.category = category;
            this.emailService = emailService;
            this.mapper = mapper;
        }

        public List<CategoryViewModel> GetAll()
        {
            var data = category.GetAll();

            var ret = mapper.Map<List<Category>, List<CategoryViewModel>>(data.ToList());

            return ret;
        }

        public CategoryViewModel? GetById(int id)
        {
            var cat = category.GetById(id);
            if (cat == null)
                return null;

            var catVm = mapper.Map<Category, CategoryViewModel>(cat);

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
                    var cat = mapper.Map<CategoryViewModel, Category>(model);

                    return category.Create(cat);
                }
            }
            catch (Exception ex)
            {
                //log this error
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
                    existing = mapper.Map<CategoryViewModel, Category>(model, existing);

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