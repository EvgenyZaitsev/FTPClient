using OpenQA.Selenium;
using FrameworkCore.Core.Utility.WebDriver;

namespace FrameworkCore.Core.Logic.Pages
{
    public abstract class Page
    {
        public string URI;
        public IWebDriver Driver;
        public Page()
        {
            this.Driver = WebDriver.CreateDriver();
        }
        public void OpenPage()
        {
            this.Driver.Navigate().GoToUrl(this.URI);
        }
        public void ClosePage()
        {
            this.Driver.Close();
        }
    }
}
