
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

        public override IEnumerable<Employee> GetAll()
        {
            var employees = _context.Employee
                    .Include(e => e.Company).ToList();

            return employees;
        }

        public new int Insert(Employee entity)
        {
            _context.Employee.Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public override void Update(Employee entity)
        {
            _context.Employee.Add(entity);
            _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var company = new Employee() { Id = id };
            _context.Employee.Attach(company);
            _context.Employee.Remove(company);
            _context.SaveChanges();

            return id;
        }
    }
}
