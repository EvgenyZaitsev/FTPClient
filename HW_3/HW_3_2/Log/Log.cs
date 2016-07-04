using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2.Log
{
    class Log : ILoggable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Logs { get; set; }
        public Log (string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        void ILoggable.Log()
        {
            Console.WriteLine($"{DateTime.Now} {Login} {Logs} ");
        }
    }
}
