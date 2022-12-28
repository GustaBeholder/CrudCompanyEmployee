
using CrudCompanyEmployeeApi.Crosscuting.Enum;
using CrudCompanyEmployeeApi.Crosscutting.DTO.Comany;

namespace CrudCompanyEmployeeApi.Crosscutting.DTO.Employee
{
    public class EmployeeGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeRoles Role { get; set; }
        public double Salary { get; set; }
        public CompanyGetDTO Company { get; set; }
    }
}
