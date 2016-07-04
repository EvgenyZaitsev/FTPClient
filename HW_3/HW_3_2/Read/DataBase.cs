using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2.Read
{
    class DataBase : IReadConfig
    {
        string Login { get; set; }
        string Password { get; set; }
        string Data { get; set; }
        public DataBase(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        List<string> IReadConfig.Read()
        {
            List<string> Data = new List<string>();
            for (int i = 0; i < 10; i++)
                Data.Add(GetDataFromNothing());
            return Data;
        }
        public string GetDataFromNothing()
        {
            char[] str = new char[100];
            for (int i = 0; i < 100; i++)
                str[i] = (char)new Random().Next(30, 130);
            return new string(str);
        }


    }
}
