using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AllureReporting
{
    public class Basepage
    {
        public static IWebDriver driver;
        public void SeleniumInit(string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }
        public void Close()
        {
            driver.Close();
        }
        public void Action(string opration, By by, string data)
        {
            if (opration == "write")
            {
                try
                {
                    driver.FindElement(by).SendKeys(data);
                }
                catch 
                {
                    //
                }
            }
            else if(opration == "click") 
            {
                try
                {
                    driver.FindElement(by).Click();
                }
                catch
                {
                    //
                }
            }
        }
        public void KeybaordActions(string dirct, By by)
        {
            if (dirct == "up")
            {
                driver.FindElement(by).SendKeys(Keys.ArrowUp);
            }
            else if (dirct == "down")
            {
                driver.FindElement(by).SendKeys(Keys.ArrowDown);
                
            }
            else if (dirct == "enter")
            {
                driver.FindElement(by).SendKeys(Keys.Enter);
            }
        }
    }
}
