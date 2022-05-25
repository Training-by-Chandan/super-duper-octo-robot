using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Db
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext() : base("name=Default")
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}