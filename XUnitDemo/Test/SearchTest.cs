using Demo1.Pages;
using Xunit;
using XUnitDemo.Test;
using XUnitDemo.Utilities;


namespace XUnitDemo
{
    public class SearchTest : BaseTest
    {
        [Theory]
        [InlineData("Books", "Selenium", "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver")]
        [InlineData("Books", "UI", "Laws of UX: Using Psychology to Design Better Products & Services")]
        [InlineData("Books", "Selenium", "ABC")]
        //[ClassData(typeof(SearchData))]
        //[MemberData(nameof(SearchData.Data), MemberType = typeof(SearchData))]
        //[JsonFileData("Testdata/data.json", "searchTestData")]
        public void Test1(string category, string keyword, string bookTitle)
        {
            
            HomePage homepage = new HomePage();
            homepage.OpenPage();
            homepage.SelectCategory(category);

            SearchResultsPage searchResultsPage = homepage.SearchKeyWord(keyword);
            searchResultsPage.GetAllSearchedResults();

            Assert.Equal(bookTitle, searchResultsPage.GetFirstResultValue());
            searchResultsPage.GetFirstResult().Click();
        }

       
    }
}
