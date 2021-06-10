using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Pages
{
    class HomePage : BasePageObject
    {
        private String url = "https://www.amazon.com/";
        private By dropdownSearch = By.Id("searchDropdownBox");
        private By searchBox = By.Id("twotabsearchtextbox");
        private By goButton = By.Id("nav-search-submit-button");
       public HomePage() {
        }    
        
        public void OpenPage()
        {
            OpenUrl(url);
        }
        
        public void SelectCategory(String categoryName)
        {
            var dropdownOptions = new SelectElement(Find(dropdownSearch));
            dropdownOptions.SelectByText(categoryName);
        }
        public SearchResultsPage SearchKeyWord(String keyword)
        {
            Type(keyword, searchBox);
            Click(goButton);
            return new SearchResultsPage();           
        }      
    }
}
