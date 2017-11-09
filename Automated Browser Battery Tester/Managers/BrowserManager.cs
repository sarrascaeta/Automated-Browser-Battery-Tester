using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomatedBrowserBatteryTester.Managers
{
    class BrowserManager
    {
        public static IWebDriver CreateBrowser(string browser = "chrome")
        {
            browser = browser.ToLower();
            IWebDriver driver = null;
            string driverPath = Directory.GetCurrentDirectory() + "/Drivers";

            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver(driverPath);
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;

            }

            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
