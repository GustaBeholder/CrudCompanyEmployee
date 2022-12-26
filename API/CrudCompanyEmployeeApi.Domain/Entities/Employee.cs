

using CrudCompanyEmployeeApi.Crosscuting.Enum;

namespace CrudCompanyEmployeeApi.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeRoles Role { get; set; }
        public double Salary { get; set; }

        //Entity Relations
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
