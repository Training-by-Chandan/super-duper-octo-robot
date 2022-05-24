using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win.Forms.Apps.Models;

namespace Win.Forms.Apps.Db
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=Inventory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}