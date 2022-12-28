using CrudCompanyEmployeeWeb.App.Models.Request;
using CrudCompanyEmployeeWeb.App.Models.ViewModels;

namespace CrudCompanyEmployeeWeb.App.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyViewModel>> GetAll();
        Task<bool> Create(CompanyCreateRequest request);
    }
}
