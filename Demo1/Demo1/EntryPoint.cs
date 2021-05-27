
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

class EntryPoint
{
    static void Main(string[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        // Maximize the browser window
        driver.Manage().Window.Maximize();

        // Navigate to www.amazon.com webpage
        driver.Navigate().GoToUrl("https://www.amazon.com/");

        var dropdownSearch = driver.FindElement(By.Id("searchDropdownBox"));
        var dropdownOptions = new SelectElement(dropdownSearch);
        var searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
        var goButton = driver.FindElement(By.Id("nav-search-submit-button"));


        // Select "Books" from search category dropdown
        dropdownOptions.SelectByText("Books");

        // Search "Selenium" and click "Go" button
        searchBox.SendKeys("Selenium");
        goButton.Click();

        // Click on the first searched result
        IList<IWebElement> searchResults = driver.FindElements(By.XPath("//span[@class='a-size-medium a-color-base a-text-normal']"));
        var actualTitle = searchResults[0].Text;
        //var actualTitle = searchResults[0].GetAttribute("textContent");
        searchResults[0].Click();

        // Assertion
        Assert.AreEqual(actualTitle, "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver");
        driver.Quit();
      
        
        

    }
}