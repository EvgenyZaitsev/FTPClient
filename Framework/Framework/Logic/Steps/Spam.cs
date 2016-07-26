using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logic.Pages;
using FrameworkCore.Core.Utility.WebDriver;
using OpenQA.Selenium;
using System.Configuration;
namespace Framework.Logic.Steps
{
    class Spam
    {
        public const string URL = @"https://www.gmail.com";
        public bool AutorizeAndCheckSpam()
        {
            string login1 = ConfigurationManager.AppSettings["login1"];
            string pass1 = ConfigurationManager.AppSettings["password1"];
            string login2 = ConfigurationManager.AppSettings["login2"];
            string pass2 = ConfigurationManager.AppSettings["password2"];
            string textToSend = "hello second.";
            LoginPage loginPage = new LoginPage();
            loginPage.OpenPage();
            loginPage.SetLoginAndPassword(login1, pass1);
            EmailPage emailPage = new EmailPage();
            emailPage.SendEmail(login2, textToSend);
            emailPage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login2, pass2);     
            emailPage.AddToSpam();
            emailPage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login1, pass1);
            emailPage.SendEmail(login2, $"new {textToSend}");
            emailPage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login2, pass2);
            emailPage.GoToSpam();
            return emailPage.CheckSpam($"new {textToSend}");
        }
    }
}
