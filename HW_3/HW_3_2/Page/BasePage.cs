using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HW_3_2.Page
{
    public abstract class BasePage
    {
        protected string Title { get; }
        public abstract void LoadPage();
    }
}
