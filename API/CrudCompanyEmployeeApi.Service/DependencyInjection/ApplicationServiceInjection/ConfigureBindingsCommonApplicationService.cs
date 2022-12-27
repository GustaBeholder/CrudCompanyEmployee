using CrudCompanyEmployeeApi.Service.Modules.Module;
using CrudCompanyEmployeeApi.Service.Modules.Module.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CrudCompanyEmployeeApi.Service.DependencyInjection.ApplicationServiceInjection
{
    public static class ConfigureBindingsCommonApplicationService
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<ICompanyApplicationService, CompanyApplicationService>();
            //services.AddScoped<IEmployeeApplicationService, EmployeeApplicationService>();
            
        }
    }
}
