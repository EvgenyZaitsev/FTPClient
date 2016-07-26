using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;

namespace FrameworkCore.Core.Utility.WebDriver
{
    public class WebDriver
    {
        private static IWebDriver driver = CreateDriver();
        private WebDriver() { }
        public static IWebDriver GetDriver()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driver;
        }
        public static void CloseDriver()
        {
            driver.Close();
            driver = null;
        }
        public static IWebDriver CreateDriver()
        {
            if (driver != null)
                return driver;
            string browser = "Firefox";//ConfigurationManager.AppSettings["browser"];
            switch (browser)
            {
                case "Chrome":
                    return new ChromeDriver();
                case "IE":
                    return new InternetExplorerDriver();
                case "Firefox":
                default:
                    return new FirefoxDriver();
            }
        }
    }
}
