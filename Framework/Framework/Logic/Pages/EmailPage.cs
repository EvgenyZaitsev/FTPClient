using FrameworkCore.Core.Logic.Elements;
using FrameworkCore.Core.Utility.Waiter;
using OpenQA.Selenium;
using FrameworkCore.Core.Logic.Pages;
using System;
using System.Linq;

namespace Framework.Logic.Pages
{
    class EmailPage : Page
    {
        private Button buttonCompose = new Button(By.XPath("//div[2]/div/div/div/div[2]/div/div/div/div/div"));
        private Input inputTo = new Input(By.Name("to"));
        private Input inputEmailContent = new Input(By.XPath("//td[2]/div[2]/div"));
        private Button buttonSend = new Button(By.XPath("//td/div/div/div[4]/table/tbody/tr/td/div/div[2]"));
        private Button buttonAccount = new Button(By.XPath("//div/a/span"));
        private Button buttonSignOut = new Button(By.XPath("//div[3]/div[2]/a"));
        private Button checkboxForFirstMessage = new Button(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div[7]/div/div[1]/div[2]/div/table/tbody/tr[1]/td[2]/div"));
        private Button buttonSpam = new Button(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div/div[1]/div[1]/div/div/div[2]/div[2]"));
        private Button buttonGoToSpam = new Button(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div[2]/div/div/div[2]/div/div[3]/div/div[1]/div/div[3]/div/div/div[1]"));
        private Input inputSearch = new Input(By.XPath("/html/body/div[7]/div[3]/div/div[1]/div[4]/div[1]/div[1]/div[3]/div/div/div/form/fieldset[2]/div/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/input[1]"));
        private Button buttonSearch = new Button(By.XPath("/html/body/div[7]/div[3]/div/div[1]/div[4]/div[1]/div[1]/div[3]/div/div/div/form/div/button"));

        private Button buttonForwarding = new Button(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div/div/div/div[6]/div/table/tbody/tr[1]/td[2]/div/div[2]/input"));
        private Input inputForwardAdress = new Input(By.XPath("//*[@class='PN']/input"));
        private Button buttonForFirstMessage = new Button(By.XPath("//div[2]/div/table/tbody/tr/td[4]"));
        private Link linkConfirmation = new Link(By.XPath("//a[4]"));



        public void SendEmail(string receiverEmail, string text)
        {
            Waiter.ExplicitWaitBy(20, buttonCompose.By).Click();
            Waiter.ExplicitWaitBy(20, inputTo.By).SendKeys(receiverEmail);
            Waiter.ExplicitWaitBy(20, inputEmailContent.By).SendKeys(text);
            Waiter.ExplicitWaitBy(20, buttonSend.By).Click();
        }
        public void Logout()
        {
            Waiter.ExplicitWaitBy(20, buttonAccount.By).Click();
            Waiter.ExplicitWaitBy(20, buttonSignOut.By).Click();
        }
        public void AddToSpam()
        {
            if(Driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div[7]/div/div[1]/div[2]/div/table/tbody/tr[1]/td[5]/div[2]/span")).Text == "Test 1")
            {
                Waiter.ExplicitWaitBy(20, checkboxForFirstMessage.By).Click();
                Waiter.ExplicitWaitBy(20, buttonSpam.By).Click();
                Waiter.ExplicitWaitBy(20, inputSearch.By).SendKeys("in:spam");
                Waiter.ExplicitWaitBy(20, buttonSearch.By).Click();
            }
        }
        public void GoToSpam()
        {
            Waiter.ExplicitWaitBy(20, inputSearch.By).SendKeys("in:spam");
            Waiter.ExplicitWaitBy(20, buttonSearch.By).Click();
        }
        public bool CheckSpam(string text)
        {
            return Driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div[2]/div[4]/div[1]/div/table/tbody/tr[1]/td[6]/div/div/div/span[2]")).Text == $" - {text}";
        }

        public void GoToForwarding()
        {
            Driver.Navigate().GoToUrl(@"https://mail.google.com/mail/u/0/#settings/fwdandpop");
        }
        public void SetForward(string email)
        {
            Waiter.ExplicitWaitBy(20, buttonForwarding.By).Click();
            Waiter.ExplicitWaitBy(20, inputForwardAdress.By).SendKeys(email);
            Driver.FindElement(By.XPath("//div[3]/button")).Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            Driver.FindElement(By.XPath("//input[@value='Proceed']")).Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.First());
            Driver.FindElement(By.Name("ok")).Click();
        }
        public void ConfirmForward()
        {
            Waiter.ExplicitWaitBy(20, buttonForFirstMessage.By).Click();
            Waiter.ExplicitWaitBy(20, linkConfirmation.By).Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            Driver.FindElement(By.XPath("//input")).Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.First());
        }
    }
}
