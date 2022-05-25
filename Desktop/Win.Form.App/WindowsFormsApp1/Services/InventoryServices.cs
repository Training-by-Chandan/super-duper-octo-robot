using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Db;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    public class InventoryServices
    {
        private DefaultDbContext db = new DefaultDbContext();

        public List<Inventory> GetAll()
        {
            return db.Inventories.ToList();
        }
    }
}