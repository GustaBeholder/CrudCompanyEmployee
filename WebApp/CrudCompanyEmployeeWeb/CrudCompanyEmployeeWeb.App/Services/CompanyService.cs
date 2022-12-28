using CrudCompanyEmployeeWeb.App.Models.Request;
using CrudCompanyEmployeeWeb.App.Models.ViewModels;
using CrudCompanyEmployeeWeb.App.Services.Interfaces;
using CrudCompanyEmployeeWeb.App.Utils;

namespace CrudCompanyEmployeeWeb.App.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly HttpClient _httpClient;

        public CompanyService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<bool> Create(CompanyCreateRequest request)
        {
            var stringContent = JsonUtils.ObterStringContent(request);

            var response = await _httpClient.PostAsync("https://localhost:44361/Company", stringContent);

            if (response.IsSuccessStatusCode) return true;

            return false;
        }

        public async Task<IEnumerable<CompanyViewModel>> GetAll()
        {
            var response = await _httpClient.GetAsync("https://localhost:44361/Company");

            return await JsonUtils.Deserializar<IEnumerable<CompanyViewModel>>(response);

        }
    }
}
