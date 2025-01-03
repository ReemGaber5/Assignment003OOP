using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment003
{
    public class BasicAuthenticationService:IAuthenticationService
    {
        private readonly Dictionary<string, (string Password, string Role)> users = new()
        {
            { "admin", ("password123", "Administrator") },
            { "user", ("userpassword", "User") }
        };

        public bool AuthenticationUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].Password == password)
            {

                return true;
            }
            else
                return false;
        }

        public bool AuthorizationUser(string username, string role)
        {
            if (users.ContainsKey(username) && users[username].Role == role)
            {

                return true;
            }
            else
                return false;

        }






    }
}
