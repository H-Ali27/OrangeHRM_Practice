using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AllureReporting
{
    public class AdminPanel : Basepage
    {
        Basepage basepage = new Basepage();

        By admin = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a");
        By addbtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
        public void Admin_Panel()
        {
            basepage.Action("click",admin,"admin");
            Thread.Sleep(3000);
            basepage.Action("click",addbtn,"add btn");
            Thread.Sleep(3000);

        }
    }
}
