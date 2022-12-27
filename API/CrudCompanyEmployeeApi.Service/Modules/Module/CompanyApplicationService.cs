

using CrudCompanyEmployeeApi.Crosscutting.DTO;
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
            foreach(var company in companies)
            {
                response.Add(new CompanyGetDTO
                {
                    Id = company.Id,
                    Name = company.Name,
                    Phone = company.Phone,
                    Adress = new CompanyAddressDTO
                    {
                        Address = company.Address.Address,
                        Number = company.Address.Number,
                        Cep = company.Address.Cep,
                        ExtraInfo = company.Address.ExtraInfo,
                        Neighborhood = company.Address.Neighborhood,
                        State = company.Address.State
                    }

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
                Adress = new CompanyAddressDTO
                {
                    Address = company.Address.Address,
                    Number = company.Address.Number,
                    Cep = company.Address.Cep,
                    ExtraInfo = company.Address.ExtraInfo,
                    Neighborhood = company.Address.Neighborhood,
                    State = company.Address.State
                }
            };

            return response;
        }

        public int Insert(CompanyInsertDTO companyDto)
        {
            Company company = new Company
            {
                Name = companyDto.Name,
                Phone = companyDto.Phone,
                Address = new CompanyAddress
                {
                    Address = companyDto.AddressDTO.Address,
                    Number = companyDto.AddressDTO.Number,
                    Cep = companyDto.AddressDTO.Cep,
                    ExtraInfo = companyDto.AddressDTO.ExtraInfo,
                    Neighborhood = companyDto.AddressDTO.Neighborhood,
                    State = companyDto.AddressDTO.State
                }
            };

            _uow.CompanyRepository.Insert(company);

            return 1;
        }

        public void Update(CompanyUpdateDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
