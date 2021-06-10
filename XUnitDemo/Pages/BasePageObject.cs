using Demo1.Driver;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Pages
{
    class BasePageObject
    {
        public BasePageObject()
        {            
        }
        protected void OpenUrl(string url)
        {
            BrowserFactory.LoadApplication(url);
        }       

        protected IWebElement Find(By locator)
        {
            return BrowserFactory.Driver.FindElement(locator);
        }

        protected IList<IWebElement> FindAll(By locator)
        {
            return BrowserFactory.Driver.FindElements(locator);

        }

        protected void Type(String input, By locator)
        {
            Find(locator).SendKeys(input);
        }

        protected void Click(By locator)
        {
            Find(locator).Click();
        }
    }
}
