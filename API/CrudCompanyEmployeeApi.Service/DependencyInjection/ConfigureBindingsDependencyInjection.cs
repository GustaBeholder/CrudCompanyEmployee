using CrudCompanyEmployeeApi.Service.DependencyInjection.ApplicationServiceInjection;
using CrudCompanyEmployeeApi.Service.DependencyInjection.DatabaseInjection;
using CrudCompanyEmployeeApi.Service.DependencyInjection.RepositoryInjection;
using CrudCompanyEmployeeApi.Service.DependencyInjection.UnitOfWork;
using CrudCompanyEmployeeApi.Service.DependencyInjection.ValidatorInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CrudCompanyEmployeeApi.Service.DependencyInjection
{
    public static class ConfigureBindingsDependencyInjection
    {
        
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            #region Application Service

            ConfigureBindingsCommonApplicationService.RegisterBindings(services);

            #endregion

            #region Repository

            ConfigureBindingsCommonRepository.RegisterBindings(services);

            #endregion

            #region Unit Of Work

            ConfigureBindingsCommonUnitOfWork.RegisterBindings(services);

            #endregion

            #region Validation

            ConfigureBindingsCommonValidations.RegisterBindings(services);

            #endregion

            #region Database
            ConfigureBindingsDatabaseInjection.RegisterBindings(services, configuration);
            #endregion
        }
    }
}
