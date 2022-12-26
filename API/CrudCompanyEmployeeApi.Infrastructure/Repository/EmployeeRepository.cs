
using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {
        }

        public override Employee GetById(int id)
        {
            Employee employee =  _context.Employee.Where(e => e.Id == id)
                .Include(e => e.Company).FirstOrDefault()!;

            return employee;
        }
    }
}
