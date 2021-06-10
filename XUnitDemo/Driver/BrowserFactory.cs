using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Driver
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();

        public static IWebDriver Driver
        {
            get; set;            
        }

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":                   
                        Driver = new FirefoxDriver();
                        Drivers.Add("Firefox", Driver);                   
                    break;
                case "Chrome":
                        Driver = new ChromeDriver();
                        Drivers.Add("Chrome", Driver);                    
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void RemoveDriver(string browser)
        {
            if (Drivers.ContainsKey(browser))
            {
                Drivers.Remove(browser);
            }
        }
        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

    }
}
