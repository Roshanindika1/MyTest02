using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace myTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Open the chrome brower
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


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
