using Demo1.Driver;
using Microsoft.Extensions.Configuration;
using System;

namespace XUnitDemo.Test
{
    public class BaseTest : IDisposable
    {
        public static IConfigurationRoot config = new ConfigurationBuilder()
               .AddJsonFile("configFile.json")
               .Build();
        public static string browser = config["browser"];
        public BaseTest()
        {           
            BrowserFactory.InitBrowser(browser);
            BrowserFactory.Driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            BrowserFactory.CloseAllDrivers();
            BrowserFactory.RemoveDriver(browser);
        }
    }
}
