
using CrudCompanyEmployeeApi.Crosscuting.Enum;

namespace CrudCompanyEmployeeApi.Crosscutting.DTO.Employee
{
    public class EmployeeUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeRoles Role { get; set; }
        public double Salary { get; set; }
    }
}
