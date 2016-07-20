using Framework.Core.Logic.Elements;
using Framework.Core.Utility.Exceptions;
namespace Framework.Core.Logic.Pages
{
    class LoginPage : Page
    {
        private string login;
        private string password;
        public Button submit;
        public void SetLoginAndPassword(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public void Connect()
        {
            if (this.login != null && this.password != null)
                submit.Click();
            throw new InvalidDataException("Not Entered Login or Password. Reenter it.");
        }
    }
}
