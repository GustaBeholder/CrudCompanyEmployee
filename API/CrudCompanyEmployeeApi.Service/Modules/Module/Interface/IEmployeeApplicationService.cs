
using CrudCompanyEmployeeApi.Crosscutting.DTO.Employee;

namespace CrudCompanyEmployeeApi.Service.Modules.Module.Interface
{
    public interface IEmployeeApplicationService 
    {
        IEnumerable<EmployeeGetDTO> GetAll();
        EmployeeGetDTO GetById(int id);
        int Insert(EmployeeInsertDTO company);  
        int Update(EmployeeUpdateDTO company); 
        int Delete(int id); 
    }
}
