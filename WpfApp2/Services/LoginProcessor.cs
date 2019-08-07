using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    public static class LoginProcessor
    {
        public static bool isTrue { get; set; }
        public static async Task LoadLogin(String login, String password)
        {
            if (login != "" && password != "")
            {
                LoginModel login_attempt = new LoginModel(login, password);
                string url = "checkpassword";
                using (var response = await ApiHelper.ApiClient.PostAsJsonAsync(url, login_attempt))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        if (responseString.Equals("true")) isTrue = true;
                        else isTrue = false;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            else
            {
                isTrue = false;
            }
        }


    }
}
