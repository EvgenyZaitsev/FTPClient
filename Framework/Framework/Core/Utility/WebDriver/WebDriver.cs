using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using Framework.Core.Utility.Exceptions;
using System.Configuration;

namespace Framework.Core.Utility.WebDriver
{
    public class WebDriver
    {
        private static IWebDriver driver = CreateDriver();
        private WebDriver() { }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
        public static IWebDriver CreateDriver()
        {
            string browser = ConfigurationManager.AppSettings["browser"];
            switch (browser)
            {
                case "Chrome":
                    return new ChromeDriver();
                case "Firefox":
                    return new FirefoxDriver();
                case "IE":
                    return new InternetExplorerDriver();
                default:
                    throw new InvalidDataException($"Can't continue work with browser {browser}. Please, use another one.");
            }
        }
    }
}
