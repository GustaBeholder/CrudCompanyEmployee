
namespace CrudCompanyEmployeeApi.Crosscutting.DTO
{
    public class CompanyInsertDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public CompanyAddressDTO AddressDTO { get; set; }
    }
}
