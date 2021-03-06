﻿using OpenQA.Selenium;

namespace FrameworkCore.Core.Logic.Elements
{
    class RadioButton : Element
    {
        public RadioButton(By by) : base(by)
        {
        }

        public string ID { get; set; }
        public string Text { get; set; }
        public bool Visible { get; set; }
        public bool Selected { get; set; }
    }
}
