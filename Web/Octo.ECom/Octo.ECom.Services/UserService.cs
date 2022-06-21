using Microsoft.AspNetCore.Identity;
using Octo.ECom.Models.ViewModels;
using Octo.ECom.Repository;

namespace Octo.ECom.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        private readonly IUserRoleRepository userRoleRepository;

        public UserService(
                IUserRepository userRepository,
                IRoleRepository roleRepository,
                IUserRoleRepository userRoleRepository
            )
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.userRoleRepository = userRoleRepository;
        }

        public (bool, string) CreateUser(AdminUserCreateViewModel model)
        {
            try
            {
                //create a hasher object
                PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
                //create identityuser object
                var user = new IdentityUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = model.Email,
                    NormalizedUserName = model.Email.ToUpper(),
                    Email = model.Email,
                    NormalizedEmail = model.Email.ToUpper(),
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };
                //create password hash
                user.PasswordHash = hasher.HashPassword(user, model.Password);
                //create user
                var res = userRepository.Create(user);
                //if created
                if (res.Item1)
                {
                    //get the roleId
                    var roleid = roleRepository.GetRoleId(model.Roles.ToString());
                    //prepare identityuserrole object
                    var userRole = new IdentityUserRole<string>()
                    {
                        RoleId = roleid,
                        UserId = user.Id
                    };
                    //create the identityt iser role
                    return userRoleRepository.Create(userRole);
                }
                //else return faile result
                return res;
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

    public interface IUserService
    {
        (bool, string) CreateUser(AdminUserCreateViewModel model);
    }
}