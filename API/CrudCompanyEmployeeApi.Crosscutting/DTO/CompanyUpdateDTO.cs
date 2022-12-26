using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCompanyEmployeeApi.Crosscutting.DTO
{
    public class CompanyUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public CompanyAddressDTO Address { get; set; }
    }
}
