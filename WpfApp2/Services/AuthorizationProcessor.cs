using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    class AuthorizationProcessor
    {
        public static async Task LoadAuth()
        {
            string url = "api/auth";
            AuthorizationModel.AuthorizationKey = await ApiHelper.ApiClient.GetStringAsync(url);

        }
    }
}
