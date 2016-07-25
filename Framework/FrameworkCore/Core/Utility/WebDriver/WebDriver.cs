using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace FrameworkCore.Core.Utility.WebDriver
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
