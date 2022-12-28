using CrudCompanyEmployeeApi.Crosscutting.DTO.Comany;
using CrudCompanyEmployeeApi.Crosscutting.DTO.Employee;
using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using CrudCompanyEmployeeApi.Service.Modules.Base;
using CrudCompanyEmployeeApi.Service.Modules.Module.Interface;


namespace CrudCompanyEmployeeApi.Service.Modules.Module
{
    public class EmployeeApplicationService : BaseApplicationService<IEmployeeUnitOfWork, IEmployeeRepository, Employee>, IEmployeeApplicationService
    {
        public EmployeeApplicationService(IEmployeeUnitOfWork uow) : base(uow)
        {
        }

        public int Delete(int id)
        {
            return _uow.EmployeeRepository.Delete(id);  
        }

        public IEnumerable<EmployeeGetDTO> GetAll()
        {
            var employees = _uow.EmployeeRepository.GetAll();

            List<EmployeeGetDTO> response = new();

            foreach(Employee employee in employees)
            {
                response.Add(new EmployeeGetDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Role = employee.Role,
                    Salary = employee.Salary,
                    Company = new CompanyGetDTO
                    {
                        Id = employee.Company.Id,
                        Name = employee.Company.Name,
                        Address = employee.Company.Address,
                        Cep = employee.Company.Cep,
                        ExtraInfo = employee.Company.ExtraInfo,
                        Neighborhood = employee.Company.Neighborhood,
                        Number = employee.Company.Number,
                        Phone = employee.Company.Phone,
                        State = employee.Company.State
                    }
                    
                });
            }

            return response;
        }

        public EmployeeGetDTO GetById(int id)
        {
            var employee = _uow.EmployeeRepository.GetById(id);

            EmployeeGetDTO response = new()
            {
                Id = employee.Id,
                Name = employee.Name,
                Role = employee.Role,
                Salary = employee.Salary,
                Company = new CompanyGetDTO
                {
                    Id = employee.Company.Id,
                    Name = employee.Company.Name,
                    Address = employee.Company.Address,
                    Cep = employee.Company.Cep,
                    ExtraInfo = employee.Company.ExtraInfo,
                    Neighborhood = employee.Company.Neighborhood,
                    Number = employee.Company.Number,
                    Phone = employee.Company.Phone,
                    State = employee.Company.State
                }
            };

            return response;
        }

        public int Insert(EmployeeInsertDTO employee)
        {
            Employee insert = new()
            {
                Name = employee.Name,
                Role = employee.Role,
                Salary = employee.Salary,
                CompanyId =employee.CompanyId
            };

            return _uow.EmployeeRepository.Insert(insert);  
        }

        public int Update(EmployeeUpdateDTO employee)
        {
            Employee update = new()
            {
                Name = employee.Name,
                Role = employee.Role,
                Salary = employee.Salary
            };

            _uow.EmployeeRepository.Update(update);

            return 1;
        }
    }
}
