using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Q12
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string UserName = "sohila";
        private string Password = "123";
        private string Role = "admin";

        public bool AuthenticateUser(string userName, string password)
        {
            if (UserName == userName && Password == password) return true;
            else return false;
        }

        public bool AuthorizeUser(string userName, string role)
        {
            if (UserName == userName && Role == role) return true;
            else return false;
        }
    }
}
