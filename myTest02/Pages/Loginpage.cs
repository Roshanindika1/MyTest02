using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest02.Pages
{
    internal class Loginpage
    {
        public void loginTM(IWebDriver driver)
        {
            

            //Launch the Turn up Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Identify username text box and enter a valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");


            //Identify password text box and enter a valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();


            //Check if user is logged successfully

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, Test pass");
            }

            else
            {
                Console.WriteLine("Login fail, Test failed");
            }

        }
    }
}
