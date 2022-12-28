
using CrudCompanyEmployeeApi.Crosscuting.Enum;

namespace CrudCompanyEmployeeApi.Crosscutting.DTO.Employee
{
    public class EmployeeInsertDTO
    {
        public string Name { get; set; }
        public EmployeeRoles Role { get; set; }
        public double Salary { get; set; }
        public int CompanyId { get; set; }
    }
}
