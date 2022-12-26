

namespace CrudCompanyEmployeeApi.Domain.Entities
{
    public class CompanyAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string ExtraInfo { get; set; }
        public string Cep { get; set; }
        public Company Company { get; set; }
    }

}
