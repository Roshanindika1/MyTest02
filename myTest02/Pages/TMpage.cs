using myTest02.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myTest02.Pages
{
    internal class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
                       
            //Go to Create New page

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            //Go to Typecode dropdown box

            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecodeDropdown.Click();

            //Select the material function

            IWebElement tmMaterialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            Thread.Sleep(1000);
            tmMaterialOption.Click();

            //Go to the code dropdown box

            IWebElement codeBox = driver.FindElement(By.Id("Code"));
            codeBox.SendKeys("myTest02");

            //Go to Description box

            IWebElement descriptionBox = driver.FindElement(By.Id("Description"));
            descriptionBox.SendKeys("myTest02");

            //Go to price text box by tagging 

            IWebElement priceTagbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTagbox.Click();

            //Go to Price box

            IWebElement priceBox = driver.FindElement(By.Id("Price"));
            priceBox.SendKeys("100");

            //Go to Save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.waittobeClickable(driver, "Xpath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            //Check the create record is saved
            //Go to Last page button

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "myTest02")
            {
                Console.WriteLine("Code saved successfully, Test passed");
            }

            else
            {
                Console.WriteLine("Test Failed. Code is not saved");
            }


        }

        public void EditTM()
        { }

        public void DeleteTM()
        { }
    }
}
