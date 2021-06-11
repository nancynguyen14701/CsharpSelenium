Scripting challenge #1:

Create Data Driven & Keywork Driven in Selenium WebDriver using NUnit to verify product title with scenario as below:
	
	Open Chrome Browser
	Maximize the browser window
	Navigate to www.amazon.com webpage.
	Select "Books" from search category dropdown
	Enter search key: "Selenium"
	Click "Go" button
	Click the first search result item title
	Verify that product title is correct ("Learn Selenium: Build 		data-driven test frameworks for mobile and web applications 		with Selenium Web Driver 3")

Requirements:
	
Create common function Search()
Wrap up functions into PageObject class:
		
		GoToUrl()
		InputText()
		ClickAndWait()	
	
Create keywork driven for:
		
		WaitForElementPresent()
		WaitForElementDisplayed()
		WaitForElementClickable()
		SelectBy() to use for step 4
		Apply keyworks for this test script.	
	
Apply data driven(JSON) for this test to search with:	

		
Data 1: C# 7.0 in a Nutshell => title = "C# 7.0 in a Nutshell: The Definitive Reference"

Data 2: Test Automation using Selenium Webdriver 3.0 with C# => title = "Test Automation using Selenium Webdriver 3.0 with C#")

Data 3: Learn Selenium: => title = "Learn Selenium: Build data-driven test frameworks for mobile and web applications with Selenium Web Driver 3"
	
--> Test case should run against all test data.