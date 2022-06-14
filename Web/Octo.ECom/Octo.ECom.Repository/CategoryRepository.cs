using Octo.ECom.Data;
using Octo.ECom.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.ECom.Repository
{
    public interface ICategoryRepository
    {
        (bool, string) Create(Category model);

        (bool, string) Delete(Category model);

        (bool, string) Edit(Category model);

        IQueryable<Category> GetAll();

        Category GetById(int Id);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public IQueryable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category GetById(int Id)
        {
            return db.Categories.Find(Id);
        }

        public (bool, string) Create(Category model)
        {
            try
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Category model)
        {
            try
            {
                db.Categories.Update(model);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Category model)
        {
            try
            {
                db.Categories.Remove(model);
                db.SaveChanges();
                return (true, "Removed Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}