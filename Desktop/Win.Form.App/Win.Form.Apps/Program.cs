using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Forms.Apps.Db;
using Win.Forms.Apps.Models;

namespace Win.Forms.Apps
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            SeedData.InsertDefault();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    public class SeedData
    {
        private static DefaultDbContext db = new DefaultDbContext();

        public static void InsertDefault()
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