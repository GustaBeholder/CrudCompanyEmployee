using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork
{
    public class CompanyUnitOfWork : GenericUnitOfWork, ICompanyUnitOfWork
    {
        public CompanyUnitOfWork(ApplicationContext session, IServiceProvider serviceProvider) : base(session, serviceProvider)
        {
        }

        public ICompanyRepository CompanyRepository => 
            _serviceProvider.GetService<ICompanyRepository>();
    }
}
