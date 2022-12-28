using CrudCompanyEmployeeApi.Crosscutting.DTO.Comany;
using CrudCompanyEmployeeApi.Crosscutting.DTO.Employee;
using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using CrudCompanyEmployeeApi.Service.Modules.Base;
using CrudCompanyEmployeeApi.Service.Modules.Module.Interface;

namespace CrudCompanyEmployeeApi.Service.Modules.Module
{
    public class CompanyApplicationService : BaseApplicationService<ICompanyUnitOfWork, ICompanyRepository, Company>, ICompanyApplicationService
    {
        public CompanyApplicationService(ICompanyUnitOfWork uow) : base(uow)
        {
        }

        public IEnumerable<CompanyGetDTO> GetAll()
        {
            var companies = _uow.CompanyRepository.GetAll();

            var response = new List<CompanyGetDTO>();

            //Add Employees
            foreach (var company in companies)
            {
                response.Add(new CompanyGetDTO
                {
                    Id = company.Id,
                    Name = company.Name,
                    Phone = company.Phone,
                    Address = company.Address,
                    Number = company.Number,
                    Cep = company.Cep,
                    ExtraInfo = company.ExtraInfo,
                    Neighborhood = company.Neighborhood,
                    State = company.State,
                    Employees = MapEmployee(company.Employees)
                });
            }
            return response;
        }

        public CompanyGetDTO GetById(int id)
        {
            var company = _uow.CompanyRepository.GetById(id);

            var response = new CompanyGetDTO
            {
                Id = company.Id,
                Name = company.Name,
                Phone = company.Phone,

                Address = company.Address,
                Number = company.Number,
                Cep = company.Cep,
                ExtraInfo = company.ExtraInfo,
                Neighborhood = company.Neighborhood,
                State = company.State,
                Employees = MapEmployee(company.Employees)

            };

            return response;
        }

        public int Insert(CompanyInsertDTO companyDto)
        {
            Company company = new()
            {
                Name = companyDto.Name,
                Phone = companyDto.Phone,

                Address = companyDto.Address,
                Number = companyDto.Number,
                Cep = companyDto.Cep,
                ExtraInfo = companyDto.ExtraInfo,
                Neighborhood = companyDto.Neighborhood,
                State = companyDto.State,

            };

            return _uow.CompanyRepository.Insert(company); ;
        }

        public int Update(CompanyUpdateDTO companyDto)
        {
            Company company = new()
            {
                Id = companyDto.Id,
                Name = companyDto.Name,
                Phone = companyDto.Phone,
                Address = companyDto.Address,
                Number = companyDto.Number,
                Cep = companyDto.Cep,
                ExtraInfo = companyDto.ExtraInfo,
                Neighborhood = companyDto.Neighborhood,
                State = companyDto.State

            };

            _uow.CompanyRepository.Update(company);

            return 1;
        }

        public int Delete(int id)
        {
            return _uow.CompanyRepository.Delete(id);
        }

        private static IEnumerable<EmployeeGetDTO> MapEmployee(IEnumerable<Employee> employees)
        {
            List<EmployeeGetDTO> response = new();

            foreach(var employee in employees)
            {
                response.Add(new EmployeeGetDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Role = employee.Role,
                    Salary = employee.Salary
                });
            }

            return response;
        }
    }
}
