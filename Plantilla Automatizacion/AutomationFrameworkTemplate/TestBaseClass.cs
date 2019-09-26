using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationFrameworkTemplate
{
    public class TestBaseClass : SuperBaseClass
    {

        [TestInitialize]
        public void Setup()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            WebDriver.Navigate().GoToUrl("http://testingcr-demo.glitch.me/");
        }

        [TestCleanup]
        public void CleanUp()
        {
            WebDriver.Close();
        }
    }
}
