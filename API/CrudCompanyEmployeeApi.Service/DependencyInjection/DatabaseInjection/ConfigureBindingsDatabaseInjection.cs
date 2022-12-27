

using CrudCompanyEmployeeApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudCompanyEmployeeApi.Service.DependencyInjection.DatabaseInjection
{
    public static class ConfigureBindingsDatabaseInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("DefaultConnection")!;

            services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));
        }
    }
}
