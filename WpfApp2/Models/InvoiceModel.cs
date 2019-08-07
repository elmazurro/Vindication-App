using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Services;

namespace WpfApp2.Models
{
    public class InvoiceModel
    {
        public InvoiceModel(string invoice, double netAmount, double grossAmount, double percent, string companyId, string employeeId, DateTime? dateOfReturn)
        {
            this.invoice = invoice;
            this.netAmount = netAmount;
            this.grossAmount = grossAmount;
            this.percent = percent;
            interest = grossAmount * percent;
            this.companyId = Convert.ToInt32(companyId);
            this.employeeId = Convert.ToInt32(employeeId);
            this.dateOfReturn = dateOfReturn;
        }
        public int id{ get; set; }
        public string invoice { get; set; }
        public double netAmount { get; set; }
        public double grossAmount { get; set; }
        public double interest { get; set; }
        public double percent { get; set; }
        public int companyId { get; set; }
        public int employeeId { get; set; }
        public DateTime? dateOfReturn{ get; set; }

        public string companyIdToString()
        {
            CompanyModel temp = CompanyProcessor.data.SingleOrDefault(item => item.id == this.companyId);
            return temp.companyName;
        }
        public string employeeIdToString()
        {
            RepresentativeModel temp = RepresentativeProcessor.data.SingleOrDefault(item => item.id == this.employeeId);
            return temp.name + ' ' + temp.surname;
        }
    }
}
