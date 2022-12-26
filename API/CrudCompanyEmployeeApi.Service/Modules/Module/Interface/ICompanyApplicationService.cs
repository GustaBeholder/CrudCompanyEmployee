using CrudCompanyEmployeeApi.Crosscutting.DTO;

namespace CrudCompanyEmployeeApi.Service.Modules.Module.Interface
{
    public interface ICompanyApplicationService
    {
        IEnumerable<CompanyGetDTO> GetAll();
        CompanyGetDTO GetById(int id);
        int Insert(CompanyInsertDTO company);  
        void Update(CompanyUpdateDTO company); 
    }
}
