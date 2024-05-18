using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AllureReporting
{
    public class Adduser : Basepage
    {
        Basepage basepage = new Basepage();

        By userRole = By.CssSelector(":nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input");
        By EmpName = By.CssSelector(":nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input");
        By status = By.CssSelector(":nth-child(3) > .oxd-input-group > :nth-child(2) > .oxd-select-wrapper > .oxd-select-text > .oxd-select-text-input");
        By username = By.CssSelector(":nth-child(1) > div > div:nth-child(4) > div > div:nth-child(2) > input");
        By password = By.CssSelector(".oxd-grid-item.oxd-grid-item--gutters.user-password-cell > div > div:nth-child(2) > input");
        By confpass = By.CssSelector(":nth-child(2) > div > div:nth-child(2) > input");
        By savebtn = By.CssSelector(".oxd-button--secondary");

        public void Add_User()
        {
            Thread.Sleep(3000);
            basepage.KeybaordActions("down", userRole);
            basepage.KeybaordActions("down", userRole);
            basepage.KeybaordActions("enter", userRole);
            Thread.Sleep(3000);

            basepage.Action("write", EmpName,"jo");
            Thread.Sleep(2000);
            basepage.KeybaordActions("down", EmpName);
            basepage.KeybaordActions("enter", EmpName);

            basepage.KeybaordActions("down", status);
            Thread.Sleep(2000);
            basepage.KeybaordActions("enter", status);

            basepage.Action("write", username, "hamza");
            basepage.Action("write", password, "Aliali.123");
            basepage.Action("write", confpass, "Aliali.123");
            basepage.Action("click", savebtn, "SaveBtn");
            Thread.Sleep(9000);

        }
    }
}
