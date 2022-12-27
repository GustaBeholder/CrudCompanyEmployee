
using CrudCompanyEmployeeApi.Domain.Entities;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        int Insert(Company entity);
    }
}
