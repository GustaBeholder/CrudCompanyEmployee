using CrudCompanyEmployeeWeb.App.Models.Enum;

namespace CrudCompanyEmployeeWeb.App.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeRoles Role { get; set; }
        public double Salary { get; set; }
        public int CompanyId { get; set; }
    }
}