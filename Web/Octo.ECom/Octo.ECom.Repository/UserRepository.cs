using Microsoft.AspNetCore.Identity;
using Octo.ECom.Data;

namespace Octo.ECom.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext db;

        public UserRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public (bool, string) Create(IdentityUser user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return (true, "User created successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

    public interface IUserRepository
    {
        (bool, string) Create(IdentityUser user);
    }
}