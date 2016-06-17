using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient
{
    class Client
    {
        private string login;
        private string password;
        public Client(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
