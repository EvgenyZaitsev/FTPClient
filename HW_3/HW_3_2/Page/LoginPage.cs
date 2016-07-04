using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_3_2.Element;

namespace HW_3_2.Page
{
    public class LoginPage : BasePage
    {
        string Login { get; set; }
        string Password { get; set; }
        public Button Save { get; set; }
        public TextArea TA { get; set; }
        public override void LoadPage()
        {
            /* Some Method*/
        }
        public void LogOn()
        {
            /*Put Login and Password to login form*/
        }
    }
}
