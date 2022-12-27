using CrudCompanyEmployeeApi.Service.DependencyInjection.ApplicationServiceInjection;
using CrudCompanyEmployeeApi.Service.DependencyInjection.RepositoryInjection;
using CrudCompanyEmployeeApi.Service.DependencyInjection.UnitOfWork;
using CrudCompanyEmployeeApi.Service.DependencyInjection.ValidatorInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCompanyEmployeeApi.Service.DependencyInjection
{
    public static class ConfigureBindingsDependencyInjection
    {
        
        public static void RegisterBindings(IServiceCollection services)
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
        }
    }
}
