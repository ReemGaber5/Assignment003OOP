using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment003
{
    public interface IAuthenticationService
    {
        bool AuthenticationUser(string username, string password);
        bool AuthorizationUser(string username, string role);
    }
}
