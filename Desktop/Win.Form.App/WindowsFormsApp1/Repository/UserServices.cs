using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Db;

namespace WindowsFormsApp.Repository
{
    public class UserRepository
    {
        private DefaultDbContext db = new DefaultDbContext();

        public (bool, string) Login(string username, string password)
        {
            try
            {
                //check the user existence
                var exists = db.UserInfos.FirstOrDefault(p => p.Username == username);
                if (exists == null)
                {
                    return (false, "User not found");
                }
                else
                {
                    if (exists.Password != password)
                    {
                        return (false, "Password does not match");
                    }
                    else
                    {
                        return (true, "Password matched");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}