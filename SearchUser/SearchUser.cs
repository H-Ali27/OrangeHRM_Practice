using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AllureReporting
{
    public class SearchUser : Basepage
    {
        Basepage basepage = new Basepage();
        By username = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > input");
        By searchbtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary");
        By deleteBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-body > div > div > div:nth-child(6) > div > button:nth-child(1)");
        By deleteCnfrm = By.CssSelector("#app > div.oxd-overlay.oxd-overlay--flex.oxd-overlay--flex-centered > div > div > div > div.orangehrm-modal-footer > button.oxd-button.oxd-button--medium.oxd-button--label-danger");
        public void search_user()
        {
            basepage.Action("write",username,"hamza");
            basepage.Action("click",searchbtn,"search");
            Thread.Sleep(8000);
            basepage.Action("click", deleteBtn, "delete");
            basepage.Action("click", deleteCnfrm, "deleteConfrms");
            Thread.Sleep(8000);
        }
    }
}
