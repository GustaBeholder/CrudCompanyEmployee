

namespace CrudCompanyEmployeeApi.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string ExtraInfo { get; set; }
        public string Cep { get; set; }

        //Entity Relations

        public IEnumerable<Employee> Employees { get; set; }

    }
}
