
using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext context) : base(context){ }

        public int Delete(int id)
        {
            var company = new Company() { Id = id };
            _context.Company.Attach(company);
            _context.Company.Remove(company);
            _context.SaveChanges();

            return id;
        }

        public override IEnumerable<Company> GetAll()
        {
            List<Company> companies = _context.Company
                .Include(c => c.Employees).ToList();

            return companies;
        }

        public override Company GetById(int id)
        {
            Company company = _context.Company
                .Include(c => c.Employees).FirstOrDefault(c => c.Id == id)!;

            return company;
        }

        public new int Insert(Company entity)
        {
            _context.Company.Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public override void Update(Company entity)
        {
            _context.Company.Add(entity);
            _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
