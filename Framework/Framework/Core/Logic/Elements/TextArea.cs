using OpenQA.Selenium;

namespace Framework.Core.Logic.Elements
{
    public class TextArea : Element
    {
        public string ID { get; set; }
        public string Text { get; set; }
        public bool Visible { get; set; }
    }
}
