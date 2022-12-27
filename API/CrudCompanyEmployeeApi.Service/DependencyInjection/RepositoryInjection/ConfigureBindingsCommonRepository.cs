using CrudCompanyEmployeeApi.Infrastructure.Repository;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace CrudCompanyEmployeeApi.Service.DependencyInjection.RepositoryInjection
{
    public static class ConfigureBindingsCommonRepository
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
