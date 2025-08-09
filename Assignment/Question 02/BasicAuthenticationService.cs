using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticationUser(string UserName, string Password)
        {
            if (UserName == "admin" && Password == "1234")
                return true;
            else
                return false;
        }

        public bool AuthorizedUser(string UserName, string Role)
        {
            if (UserName == "admin" && Role == "Administrator")
            {
                return true;
            }
            return false;
        }
    }
}
