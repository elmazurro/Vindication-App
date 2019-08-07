using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class RepresentativeModel
    {
        public RepresentativeModel( string name, string surname, int phoneNumber,
            string email, int companyId)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.companyId = companyId;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public int companyId { get; set; }
    }
}
