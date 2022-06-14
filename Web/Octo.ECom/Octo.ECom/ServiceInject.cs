using Octo.ECom.Repository;
using Octo.ECom.Services;

namespace Octo.ECom
{
    public class ServiceInject
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Repository

            services.AddTransient<ICategoryRepository, CategoryRepository>();

            #endregion Repository

            #region Services

            services.AddTransient<ICategoryService, CategoryService>();

            #endregion Services
        }
    }
}