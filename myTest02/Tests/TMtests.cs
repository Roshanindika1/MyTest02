using myTest02.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace myTest02
{
    internal class TMtests
    {
        static void Main(string[] args)
        {

            //Open the chrome brower
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initialization and define
            Loginpage loginPageObj = new Loginpage();
            loginPageObj.loginTM(driver);

            //Home page object initialization and define
            Homepage HomePageObj = new Homepage();
            HomePageObj.homeTM(driver);
            
            
            //TMpage page object initialization and define
            TMpage TMpageObj = new TMpage();
            TMpageObj.CreateTM(driver);





        }
    }
}
