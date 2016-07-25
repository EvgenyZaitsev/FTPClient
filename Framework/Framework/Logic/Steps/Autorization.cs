using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logic.Pages;
using FrameworkCore.Core.Utility.WebDriver;
using OpenQA.Selenium;

namespace Framework.Logic.Steps
{
    class Autorization
    {
        public const string URL = @"https://www.gmail.com";
        public void Autorize()
        {
            string login1 = "1testacc250716@gmail.com";
            string pass1 = "testacc250716";
            string login2 = "zedos96@gmail.com";
            string pass2 = "11061996";
            string textToSend = "hello second.";
            LoginPage loginPage = new LoginPage();
            loginPage.OpenPage();
            loginPage.SetLoginAndPassword(login1, pass1);
            HomePage homePage = new HomePage();
            homePage.SendEmail(login2, textToSend);
            homePage.Logout();
            loginPage.SwitchUser();
            loginPage.SetLoginAndPassword(login2, pass2);     
            homePage.AddToSpam();
            homePage.Logout();
            loginPage.SwitchUser();
        }
    }
}
