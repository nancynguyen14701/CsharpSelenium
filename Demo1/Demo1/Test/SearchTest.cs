using Demo1.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo1.Test
{
    class SearchTest
    {
        static void Main(String[] args)
        {
            HomePage homepage = new HomePage("Chrome");
            homepage.selectCategory("Books");

            SearchResultsPage searchResultsPage = homepage.searchKeyWord("Selenium");
            searchResultsPage.GetAllSearchedResults();

            Assert.Equal("Learn Selenium: Build data-driven test frameworks for mobile and web applications with Selenium Web Driver 3", searchResultsPage.getFirstResultValue());
            searchResultsPage.getFirstResult().Click();
            searchResultsPage.End();
        }
    }
}
