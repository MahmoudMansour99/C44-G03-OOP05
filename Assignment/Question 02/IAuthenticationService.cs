using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question_02
{
    internal interface IAuthenticationService
    {
        public bool AuthenticationUser(string UserName, string Password);
        public bool AuthorizedUser(string UserName, string Role);
    }
}
