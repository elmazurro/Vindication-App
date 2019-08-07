using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    public static class InvoiceProcessor
    {
        public static InvoiceModel[] data { get; set; }
        public static bool IsSendable;

        public static async Task LoadInvoices()
        {
            string url = "api/invoice";
            var response = await ApiHelper.ApiClient.GetAsync(url);
            var responseString = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                ConvertToModel(responseString);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        private static void ConvertToModel(string response)
        {
            data = JsonConvert.DeserializeObject<InvoiceModel[]>(response);
        }

        public static async Task UploadInvoice(InvoiceModel content)
        {
            if (content.companyId != 0 && content.employeeId != 0 && content.grossAmount != 0 && content.interest != 0 && content.invoice != null && content.netAmount != 0 && content.percent != 0)
            {
                string url = "api/invoice";
                var response = await ApiHelper.ApiClient.PostAsJsonAsync(url, content);
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    LoadInvoices();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            else
            {
                IsSendable = false;
            }
        }
    }
}
