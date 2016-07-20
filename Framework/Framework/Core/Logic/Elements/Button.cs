using OpenQA.Selenium;

namespace Framework.Core.Logic.Elements
{
    public class Button : Element
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public bool Visible { get; set; }
        public bool ReadOnly { get; set; }
        public void Click()
        {
            //Click button
        }
    }
}
