using Framework.Logic.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Framework.Logic.Steps
{
    class Forward
    {
        public const string URL = @"https://www.gmail.com";
        public bool ForwardMailToAnotherUser()
        {
            string login1 = ConfigurationManager.AppSettings["login1"];
            string pass1 = ConfigurationManager.AppSettings["password1"];
            string login2 = ConfigurationManager.AppSettings["login2"];
            string pass2 = ConfigurationManager.AppSettings["password2"];
            string login3 = ConfigurationManager.AppSettings["login3"];
            string pass3 = ConfigurationManager.AppSettings["password3"];
            string textToSend = "Check Forward.";
            LoginPage loginPage = new LoginPage();
            loginPage.OpenPage();
            loginPage.SetLoginAndPassword(login2, pass2);
            EmailPage emailPage = new EmailPage();
            emailPage.GoToForwarding();
            emailPage.SetForward(login3);
            emailPage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login3, pass3);
            emailPage.ConfirmForward();
            emailPage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login2, pass2);
            emailPage.GoToForwarding();




            //emailPage.AddToSpam();
            //emailPage.Logout();
            //loginPage.SwitchUser();
            //loginPage.SetLoginAndPassword(login1, pass1);
            //emailPage.SendEmail(login2, $"new {textToSend}");
            //emailPage.Logout();
            //loginPage.SwitchUser();
            //loginPage.SetLoginAndPassword(login2, pass2);
            //emailPage.GoToSpam();
            //return emailPage.CheckSpam($"new {textToSend}");
            return false;
        }
    }
}
