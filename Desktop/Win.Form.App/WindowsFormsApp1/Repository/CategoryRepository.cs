using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.Db;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Repository
{
    public class CategoryRepository
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}