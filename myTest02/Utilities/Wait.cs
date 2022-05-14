using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest02.Utilities
{
    internal class Wait
    {
        public static void waittobeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }

        }


        public static void waittobeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }

            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }

        }

    }
}
