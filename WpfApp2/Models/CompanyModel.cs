using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class CompanyModel
    {
        public CompanyModel() { }
        public CompanyModel(string companyName = null, string nip = null, string country = null, string address = null, string city = null)
        {
            this.companyName = companyName;
            this.country = country;
            this.nip = nip;
            this.address = address;
            this.city = city;
        }
        public int id {get; set; }
        public string companyName { get; set; }
        public string nip { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
    }
}
