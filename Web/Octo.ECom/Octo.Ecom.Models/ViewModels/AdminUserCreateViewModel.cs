using Octo.ECom.Models.Flags;

namespace Octo.ECom.Models.ViewModels
{
    public class AdminUserCreateViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Roles { get; set; }
    }
}