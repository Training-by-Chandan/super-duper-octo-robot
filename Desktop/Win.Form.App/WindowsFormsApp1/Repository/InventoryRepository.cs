using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Db;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Repository
{
    public class InventoryRepository
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<Inventory> GetAll()
        {
            return db.Inventories.ToList();
        }

        public Inventory GetById(int id)
        {
            return db.Inventories.Find(id);
        }

        public (bool, string) Create(Inventory model)
        {
            try
            {
                db.Inventories.Add(model);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Inventory model)
        {
            try
            {
                var exising = db.Inventories.Find(model.Id);
                if (exising == null) return (false, "Not found");

                exising.Description = model.Description;
                exising.Name = model.Name;
                exising.Price = model.Price;
                exising.CategoryId = model.CategoryId;
                exising.DateOfPurchase = model.DateOfPurchase;
                exising.Stock = model.Stock;

                db.Entry(exising).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                return (true, "updated Successfully");
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
                var exising = db.Inventories.Find(id);
                if (exising == null) return (false, "Not found");

                db.Inventories.Remove(exising);
                db.SaveChanges();
                return (true, "deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}