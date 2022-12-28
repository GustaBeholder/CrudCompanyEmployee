using CrudCompanyEmployeeApi.Crosscutting.DTO.Comany;

namespace CrudCompanyEmployeeApi.Service.Modules.Module.Interface
{
    public interface ICompanyApplicationService 
    {
        IEnumerable<CompanyGetDTO> GetAll();
        CompanyGetDTO GetById(int id);
        int Insert(CompanyInsertDTO company);  
        int Update(CompanyUpdateDTO company); 
        int Delete(int id); 
    }
}
