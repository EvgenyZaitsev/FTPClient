using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HW_3_2
{
    class WebDriverInit
    {
        public string WebBrowser { get; private set; }
        public WebDriverInit()
        {
            WebBrowser = ConfigurationManager.AppSettings["browser"];
            switch (WebBrowser)
            {
                case "Firefox":
                    {
                        //Init with Firefox
                        break;
                    }
                case "Chrome":
                    {
                        //Init with Chrome
                        break;
                    }
                case "IE":
                    {
                        //Init with IE
                        break;
                    }
                case "Safari":
                    {
                        //Init with Safari
                        break;
                    }
                default:
                    {
                        Console.WriteLine("We don't know this browser");
                        break;
                    }
            }
        }

    }
}
