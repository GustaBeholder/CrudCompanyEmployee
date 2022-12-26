

using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;

namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface
{
    public interface IEmployeeUnitOfWork : IGenericUnitOfWork 
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
