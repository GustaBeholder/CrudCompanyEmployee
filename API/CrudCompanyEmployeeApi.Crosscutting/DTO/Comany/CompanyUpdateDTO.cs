using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCompanyEmployeeApi.Crosscutting.DTO.Comany
{
    public class CompanyUpdateDTO
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
    }
}
