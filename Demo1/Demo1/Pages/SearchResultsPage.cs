using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Pages
{
    class SearchResultsPage : BasePageObject
    {
        By resultXpath = By.XPath("//span[@class='a-size-medium a-color-base a-text-normal']");
        
        public SearchResultsPage(String DriverName) : base(DriverName)
        {
        }

        public SearchResultsPage()
        {

        }

        public IList<IWebElement> GetAllSearchedResults()
        {
            return FindAll(resultXpath);
        }

        public String getFirstResultValue()
        {
            IList<IWebElement> searchedResults = GetAllSearchedResults();
            return searchedResults[0].Text;            
        }

        public IWebElement getFirstResult()
        {
            IList<IWebElement> searchedResults = GetAllSearchedResults();
            return searchedResults[0];
        }

    }
}
