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

            //Below code is to get the drivers folder path dynamically.

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        //Creates the ChomeDriver object, Executes tests on Google Chrome

        //driver = new ChromeDriver(path + @"\drivers\");
        

           driver = new ChromeDriver(@"C:\TARepo\elmavp1982\TestProjectElmaVP\TestProjectElmaVP\drivers");


            //If you want to Execute Tests on Firefox uncomment the below code

            // Specify Correct location of geckodriver.exe folder path. Ex: C:/Project/drivers

            //driver= new FirefoxDriver(path + @"\drivers\");

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