using System.Collections;
using System.Collections.Generic;

namespace XUnitDemo.TestData
{
    class SearchData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "Books", "Selenium", "Absolute Beginner (Part 1) Selenium WebDriver for Functional Automation Testing: Your Beginners Guide" };
            yield return new object[] { "Books", "UI", "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver" };

        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
       {
            new object[] {"Books", "Selenium", "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver"},
            new object[] {"Books", "UX", "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver"},
            new object[] {"Books", "FrontEnd", "Python Testing with Selenium: Learn to Implement Different Testing Techniques Using the Selenium WebDriver"},

       };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
