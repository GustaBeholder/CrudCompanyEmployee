

namespace CrudCompanyEmployeeApi.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Phone { get; set; }

        //Entity Relations
        public int AddressId { get; set; }
        public CompanyAddress Address { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

    }
}
