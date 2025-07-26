using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Q12
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string userName, string password);
  
        bool AuthorizeUser(string userName, string role);
    }
}
