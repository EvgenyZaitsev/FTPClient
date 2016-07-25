using OpenQA.Selenium;

namespace FrameworkCore.Core.Logic.Elements
{
    public abstract class Element
    {
        public By By;
        public IWebDriver driver;
        public Element(By by)
        {
            By = by;
        }
    }
}
