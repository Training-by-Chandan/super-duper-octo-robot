using Octo.ECom.Data;

namespace Octo.ECom.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext db;

        public RoleRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public string GetRoleId(string name)
        {
            return db.Roles.FirstOrDefault(p => p.Name == name).Id;
        }
    }

    public interface IRoleRepository
    {
        string GetRoleId(string name);
    }
}