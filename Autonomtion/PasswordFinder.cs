using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Autonomtion
{
    class PasswordFinder
    {

        public IWebElement textBox;
        public IWebElement button;
        public string url;

        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]

        public void SearchPassword()
        {
            driver.Manage().Window.Maximize();
            url = "https://www.wikipedia.org";
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("URL Opened");
            textBox = driver.FindElement(By.Name("search"));
            textBox.SendKeys("home");
            Console.WriteLine("Password input");
            button = driver.FindElement(By.CssSelector("#search-form > fieldset > button > i"));
            button.Click();
            Console.WriteLine("Searched");
            Thread.Sleep(5000);
        }
        [TearDown]

        public void ShutDown()
        {
            driver.Quit();
            Console.WriteLine("Test succesfull");
        }


    }
}
    
