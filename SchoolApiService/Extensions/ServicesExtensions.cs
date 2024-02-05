using SchoolApp.Core;
using SchoolApp.Core.IServices;
using SchoolApp.DAL;
using SchoolApp.Services;

namespace SchoolApiService.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureAllServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            services.AddTransient<IDepartmentService, DepartmentService>();
        }
    }
}
