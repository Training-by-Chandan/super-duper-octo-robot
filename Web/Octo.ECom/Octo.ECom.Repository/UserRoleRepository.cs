using Microsoft.AspNetCore.Identity;
using Octo.ECom.Data;

namespace Octo.ECom.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ApplicationDbContext db;

        public UserRoleRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public (bool, string) Create(IdentityUserRole<string> userRole)
        {
            try
            {
                db.UserRoles.Add(userRole);
                db.SaveChanges();
                return (true, "user role added successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

    public interface IUserRoleRepository
    {
        (bool, string) Create(IdentityUserRole<string> userRole);
    }
}