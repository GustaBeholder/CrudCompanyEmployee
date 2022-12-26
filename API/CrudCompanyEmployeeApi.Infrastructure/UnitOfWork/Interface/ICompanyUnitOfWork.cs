
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;

namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface
{
    public interface ICompanyUnitOfWork : IGenericUnitOfWork
    {
        ICompanyRepository CompanyRepository { get; }
    }
}
