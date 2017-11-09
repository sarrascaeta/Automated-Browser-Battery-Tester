using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedBrowserBatteryTester
{
    abstract class WebsiteBase
    {
        IWebDriver driver;

        public abstract void PerformNavigation();

        public void Click(string selector)
        {
            FindElement(selector).Click();
        }

        public void Go(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        private IWebElement FindElement(string selector)
        {
            By locator = null;

            if (selector.Contains("/"))
                locator = By.XPath(selector);
            else if (selector.Contains(".") || selector.Contains("+") || selector.Contains(">") || selector.Contains("#") || selector.Contains("[") || selector.Contains(":"))
                locator = By.CssSelector(selector);
            else
                locator = By.Id(selector);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));

            return driver.FindElement(locator);
        }
    }


}
