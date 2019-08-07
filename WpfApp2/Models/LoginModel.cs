using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public  class LoginModel
    {
        public LoginModel(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public String login { get; set; }
        public String password { get; set; }
    }
}
