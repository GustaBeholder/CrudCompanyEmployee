
using CrudCompanyEmployeeApi.Domain.Entities;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        int Insert(Employee entity);
        int Delete(int id);
    }
}
