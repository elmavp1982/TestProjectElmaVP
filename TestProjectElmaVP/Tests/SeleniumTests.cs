//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace SeleniumCsharp

{

    public class Tests

    {

        IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()

        {
            driver = new ChromeDriver();

        }

        [Test]

        public void verifyLogo()

        {

            driver.Navigate().GoToUrl("https://www.amazon.com/");

            Assert.IsTrue(driver.FindElement(By.Id("nav-logo-sprites")).Displayed);

        }

        [Test]

        public void verifyMenuItemcount()

        {

            ReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//ul[contains(@class,'hide-sm hide-xs bstack-mm-container')]/li"));

            Assert.AreEqual(menuItem.Count, 6);

        }

        [Test]

        public void verifySellPage()

        {

            driver.Navigate().GoToUrl("https://www.amazon.com/sell/");

            IWebElement contactUsPageHeader = driver.FindElement(By.XPath(".//div[contains(@id,'')]/h1"));

            Assert.IsTrue(contactUsPageHeader.Text.Contains("Sell with Amazon"));

        }




        [OneTimeTearDown]

        public void TearDown()

        {

            driver.Quit();

        }

    }

}