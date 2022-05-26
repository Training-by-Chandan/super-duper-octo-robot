using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.Db;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    public class CategoryServices
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}