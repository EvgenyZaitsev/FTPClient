using FrameworkCore.Core.Logic.Elements;
using FrameworkCore.Core.Logic.Pages;
using FrameworkCore.Core.Utility.Exceptions;
using FrameworkCore.Core.Utility.Waiter;
using FrameworkCore.Core.Utility.WebDriver;
using OpenQA.Selenium;

namespace Framework.Logic.Pages
{
    class LoginPage : Page
    {
        private Input inputEmail = new Input(By.Id("Email"));
        private Button buttonNext = new Button(By.Name("signIn"));
        private Input inputPassword = new Input(By.Id("Passwd"));
        private Button buttonEnter = new Button(By.XPath("//form[@id='gaia_loginform']/div[2]/div/input"));
        private Link linkChangeUser = new Link(By.Id("account-chooser-link"));
        private Link linkAddAccount = new Link(By.Id("account-chooser-add-account"));

        
        public LoginPage()
        {
            URI = @"http://gmail.com";
        }
        public void SetLoginAndPassword(string login, string password)  
        {
            Waiter.ExplicitWaitBy(1000, inputEmail.By).SendKeys(login);
            Waiter.ExplicitWaitBy(1000, buttonNext.By).Click();
            Waiter.ExplicitWaitBy(1000, inputPassword.By).SendKeys(password);
            Waiter.ExplicitWaitBy(1000, buttonEnter.By).Click();
    }
        public void SwitchUser()
        {
            Waiter.ImplicitWait(1000);
            Driver.FindElement(linkChangeUser.By).Click();
            Waiter.ExplicitWaitBy(1000, linkAddAccount.By).Click();
        }
        public void SwapUser()
        {
            Waiter.ImplicitWait(1000);
            Driver.FindElement(linkChangeUser.By).Click();
            Waiter.ExplicitWaitBy(1000, linkAddAccount.By).Click();
        }
    }
}
