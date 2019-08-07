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
    public static class RepresentativeProcessor
    {
        public static RepresentativeModel [] data { get; set; } 
        public static async Task LoadRepresentatives()
        {
            string url = "api/Representative";
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
            data = JsonConvert.DeserializeObject<RepresentativeModel[]>(response);
        }

        public static List<RepresentativeModel> RepresentativesFromCompany(int id)
        {
           List<RepresentativeModel> tempData = new List<RepresentativeModel>();
            foreach( RepresentativeModel representant in data)
            {
                if(representant.companyId == id)
                {
                    tempData.Add(representant);
                }
            }
            return tempData;
        }

        public static async Task UploadRepresentative(RepresentativeModel content)
        {
            if (content.name != null && content.surname != null && content.email != null && content.companyId != 0 && content.phoneNumber != 0)
            {
                string url = "api/Representative";
                var response = await ApiHelper.ApiClient.PostAsJsonAsync(url, content);
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    await LoadRepresentatives();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            else
            {
            }
        }
    }
}
