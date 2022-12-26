
namespace CrudCompanyEmployeeApi.Crosscutting.DTO
{
    public class CompanyGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public CompanyAddressDTO Adress { get; set; }
    }
}
