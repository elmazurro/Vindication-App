
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    public static class CompanyProcessor
    {
        public static CompanyModel[] data { get; set; }
        public static bool IsSendable;

        public static async Task LoadCompanies()
        {
            string url = "api/company";
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
            data = JsonConvert.DeserializeObject<CompanyModel[]>(response);
        }

        public static async Task UploadCompany(CompanyModel content)
        {
            if (content.address != null && content.companyName != null && content.country != null && content.nip != null && content.city != null)
            {
                string url = "api/company";
                var response = await ApiHelper.ApiClient.PostAsJsonAsync(url, content);
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    await LoadCompanies();
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
