using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_3_2.Read;
using HW_3_2.Element;
using HW_3_2.Page;
namespace HW_3_2
{
    public class Business
    {
        string Name { get; set; }
        int Age { get; set; }
        public void getDataFromDB()
        {
            DataBase db = new DataBase("admin", "admin");
            Name = db.GetDataFromNothing();
            Age = new Random().Next(1, 100);
        }
        public void setData()
        {
            LoginPage lp = new LoginPage();
            TextArea textAreaName = new TextArea();
            textAreaName.SetText(Name);
            lp.TA = textAreaName;
            TextArea textAreaAge = new TextArea();
            textAreaAge.SetText(Age.ToString());
            lp.Save = new Button();
            lp.Save.Click();
            lp.Save.UpdatePage();
        }
    }
}