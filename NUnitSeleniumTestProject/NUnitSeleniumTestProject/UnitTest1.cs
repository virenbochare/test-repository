using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumTestProject
{
    public class Tests
    {
        IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.google.com/maps/";
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }

        [Test]
        public void Test1()
        {
            webDriver.FindElement(By.Id("searchboxinput")).SendKeys("607 Northgate Ave.");
            webDriver.FindElement(By.CssSelector("ul[role='listbox'] li:nth-child(1)"));
            Assert.Pass();
        }
    }
}