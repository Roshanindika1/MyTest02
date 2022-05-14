using myTest02.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest02.Pages
{
    internal class Homepage
    {
        public void homeTM(IWebDriver driver)
        {
            //Create Time and Material record

            //Go to TM Page
            
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            Wait.waittobeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TM.Click();


        }
    }
}
