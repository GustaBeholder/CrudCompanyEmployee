using CrudCompanyEmployeeWeb.App.Models.Request;
using CrudCompanyEmployeeWeb.App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrudCompanyEmployeeWeb.App.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService) => _companyService = companyService;
  
        public async Task<IActionResult> Index()
        {
            var response = await _companyService.GetAll();
            return View(response);
        }

        public async Task<IActionResult> Create(CompanyCreateRequest request)
        {
            var response = await _companyService.GetAll();
            return View(response);
        }
    }
}
