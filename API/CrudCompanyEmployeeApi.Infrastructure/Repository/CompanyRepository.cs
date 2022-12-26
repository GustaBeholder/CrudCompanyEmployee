
using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext context) : base(context){ }

        public override IEnumerable<Company> GetAll()
        {
            List<Company> companies = _context.Company
                .Include(c => c.Address)
                .Include(c => c.Employees).ToList();

            return companies;
        }

        public override Company GetById(int id)
        {
            Company company = _context.Company
                .Include(c => c.Address)
                .Include(c => c.Employees).FirstOrDefault(c => c.Id == id)!;

            return company;
        }

        public override void Insert(Company entity)
        {
            _context.Company.Add(entity);
            _context.SaveChanges(); 
        }
    }
}
