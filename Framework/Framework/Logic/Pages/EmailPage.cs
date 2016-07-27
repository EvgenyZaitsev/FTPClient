using FrameworkCore.Core.Logic.Elements;
using FrameworkCore.Core.Utility.Waiter;
using OpenQA.Selenium;
using FrameworkCore.Core.Logic.Pages;
using System;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Configuration;

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
        private Button buttonForwardMailTo = new Button(By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input"));
        private Button buttonSaveChanges = new Button(By.XPath("//td/div/button"));
        private Link linkOpenFilters = new Link(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div/div/div/div[6]/div/table/tbody/tr[1]/td[2]/div/div[3]/span"));
        private Input inputFilterFrom = new Input(By.XPath("//span[2]/input"));
        private Link linkAdvancedFilter = new Link(By.XPath("//div[9]/div[2]"));
        private Button buttonSaveFilter = new Button(By.Name("ok"));
        private Button checkboxDeleteIt = new Button(By.XPath("//div[6]/input"));
        private Button checkboxMarkAsImportant = new Button(By.XPath("//div[8]/input"));
        private Button buttonSaveAdvancedFilter = new Button(By.XPath("//div[2]/div[5]/div"));
        private Button buttonAttachFiles = new Button(By.XPath("//td[4]/div/div/div/div/div"));


        public void SendEmail(string receiverEmail, string text)
        {
            Waiter.ExplicitWaitBy(20, buttonCompose.By).Click();
            Waiter.ExplicitWaitWithCondition(20, ExpectedConditions.ElementIsVisible(inputTo.By)).SendKeys(receiverEmail);
            Waiter.ExplicitWaitBy(20, inputEmailContent.By).SendKeys(text);
            Waiter.ExplicitWaitBy(20, buttonSend.By).Click();
        }
        public void Logout()
        {
            Thread.Sleep(2000);
            Waiter.ExplicitWaitWithCondition(20, ExpectedConditions.ElementIsVisible(buttonAccount.By)).Click();
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
        public void GoToFilters()
        {
            Driver.Navigate().GoToUrl(@"https://mail.google.com/mail/u/0/#settings/filters");
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
        public void SelectForwardToAndAddFilters(string email)
        {
            Waiter.ExplicitWaitBy(20, buttonForwardMailTo.By).Click();
            Waiter.ExplicitWaitWithCondition(20, ExpectedConditions.ElementToBeClickable(buttonSaveChanges.By)).Click();
            Thread.Sleep(4000);
            GoToForwarding();
            Thread.Sleep(4000);
            Waiter.ExplicitWaitBy(20, linkOpenFilters.By).Click();
            Waiter.ExplicitWaitBy(20, inputFilterFrom.By).SendKeys(email);
            Driver.FindElement(By.XPath("//div[7]/span/input")).Click();
            Waiter.ExplicitWaitWithCondition(20, ExpectedConditions.ElementIsVisible(linkAdvancedFilter.By)).Click();
            try
            {
                Waiter.ExplicitWaitWithCondition(5, ExpectedConditions.ElementIsVisible(buttonSaveFilter.By)).Click();
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex) { }
            Waiter.ExplicitWaitWithCondition(20, ExpectedConditions.ElementIsVisible(checkboxDeleteIt.By)).Click();
            Waiter.ExplicitWaitBy(20, checkboxMarkAsImportant.By).Click();
            Waiter.ExplicitWaitBy(20, buttonSaveAdvancedFilter.By).Click();
//            Thread.Sleep(4000);
//            GoToFilters();
//            Thread.Sleep(4000);
//            if (Driver.FindElement(By.XPath("//td[2]/span")).Text == $"from:({email}) has:attachment")
//                Driver.FindElement(By.XPath("//td/input")).Click();
        }
        public void SendEmailWithAttach(string receiverEmail, string text)
        {
            Waiter.ExplicitWaitBy(20, buttonCompose.By).Click();
            Waiter.ExplicitWaitBy(20, inputTo.By).SendKeys(receiverEmail);
            Waiter.ExplicitWaitBy(20, inputEmailContent.By).SendKeys(text);
            System.Windows.Forms.Clipboard.SetText(ConfigurationManager.AppSettings["attachPath"]);
            Waiter.ExplicitWaitBy(20, buttonAttachFiles.By).Click();
            Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait("^(v)");
            Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(5000);
            Waiter.ExplicitWaitBy(20, buttonSend.By).Click();
        }

        public void GoToBin()
        {
            Waiter.ExplicitWaitBy(20, inputSearch.By).SendKeys("in:trash");
            Waiter.ExplicitWaitBy(20, buttonSearch.By).Click();
        }
        public bool CheckInbox(string text)
        {
            return Driver.FindElement(By.XPath("//div/div/span[2]")).Text == $" - {text}";
        }
        public bool CheckBin(string text)
        {
            return Driver.FindElement(By.XPath("//div[4]/div/div/table/tbody/tr/td[6]/div/div/div/span[2]")).Text == $" - {text}";
        }
    }
    
}
