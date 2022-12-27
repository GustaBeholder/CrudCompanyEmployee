using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork
{
    public class EmployeeUnitOfWork : GenericUnitOfWork, IEmployeeUnitOfWork
    {
        public EmployeeUnitOfWork(ApplicationContext session, IServiceProvider serviceProvider) : base(session, serviceProvider)
        {
        }

        public IEmployeeRepository EmployeeRepository => _serviceProvider.GetService<IEmployeeRepository>();
    }
}
