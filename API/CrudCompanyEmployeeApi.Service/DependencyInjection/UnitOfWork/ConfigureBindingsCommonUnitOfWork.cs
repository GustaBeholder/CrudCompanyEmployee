using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace CrudCompanyEmployeeApi.Service.DependencyInjection.UnitOfWork
{
    public static class ConfigureBindingsCommonUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ICompanyUnitOfWork, CompanyUnitOfWork>();
            services.AddScoped<IEmployeeUnitOfWork, EmployeeUnitOfWork>();
            
        }
    }
}
