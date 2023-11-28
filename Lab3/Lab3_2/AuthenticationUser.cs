using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class AuthenticationUser : IAuthentication
    {
        private string _username;
        private string _password;

        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public void Authenticate()
        {
            EnterUserInfo();
        }

        public void EnterUserInfo()
        {
            Console.Write("Enter username:"); _username = Console.ReadLine();
            Console.Write("Enter password:"); _password = Console.ReadLine();
            Console.WriteLine($"Authentication using username '{_username}' and password '{_password}'");
        }

    }
}
