using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AllureReporting
{
    public class LoginPage : Basepage
    {
        Basepage basepage = new Basepage();
        By usrname = By.Name("username");
        By password = By.Name("password");
        By login = By.CssSelector("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button");
        public void Valid_login(string user, string pass)
        {
            Thread.Sleep(2000);
            basepage.Action("write",usrname,user);
            basepage.Action("write",password,pass);
            basepage.Action("click",login,"dfa");
            Thread.Sleep(2000);

        }
    }
}
