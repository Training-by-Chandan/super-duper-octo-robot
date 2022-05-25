namespace WindowsFormsApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WindowsFormsApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp.Db.DefaultDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WindowsFormsApp.Db.DefaultDbContext db)
        {
            var adminUser = new UserInfo() { Username = "admin@admin.com", Password = "Admin@123", Role = Roles.Admin };
            var normalUser = new UserInfo() { Username = "user@user.com", Password = "User@123", Role = Roles.User };

            if (!db.UserInfos.Any(p => p.Username == adminUser.Username))
            {
                db.UserInfos.Add(adminUser);
                db.SaveChanges();
            }
            if (!db.UserInfos.Any(p => p.Username == normalUser.Username))
            {
                db.UserInfos.Add(normalUser);
                db.SaveChanges();
            }
        }
    }
}