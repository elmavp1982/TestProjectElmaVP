using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System.Collections.ObjectModel;

using System.IO;

namespace TestProjectElmaVP.pages
{
    //package


    public class HomePage
    {

        IWebDriver driver;


        // Locator for Amazon logo
        By Logo = By.Id("nav-logo-sprites");


        // Method to display logo
        public void displayLogo()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
        }

    }
}
