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
        public string GetLogin()
        {
            return login;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
