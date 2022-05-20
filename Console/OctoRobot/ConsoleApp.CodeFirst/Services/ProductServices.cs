using ConsoleApp.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CodeFirst.Services
{
    public class ProductServices
    {
        private DefaultContext db = new DefaultContext();

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }

        public bool Create(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(Product product)
        {
            try
            {
                db.Products.Update(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var existing = db.Products.Find(id);
                if (existing == null) return false;

                db.Products.Remove(existing);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}