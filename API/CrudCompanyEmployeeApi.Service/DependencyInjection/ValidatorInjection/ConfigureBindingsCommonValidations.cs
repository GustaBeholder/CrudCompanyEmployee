using CrudCompanyEmployeeApi.Service.Validations.Module;
using Microsoft.Extensions.DependencyInjection;

namespace CrudCompanyEmployeeApi.Service.DependencyInjection.ValidatorInjection
{
    public static class ConfigureBindingsCommonValidations
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<CompanyValidator>();
            services.AddScoped<EmployeeValidator>();
        }
    }
}
