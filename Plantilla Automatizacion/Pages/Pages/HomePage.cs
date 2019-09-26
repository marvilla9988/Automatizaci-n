using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using OpenQA.Selenium;
using Utilities.Helpers;

namespace Pages.Pages
{
    public class HomePage
    {

        private IWebDriver _webDriver;
        private SeleniumHelper _seleniumHelper;

        public HomePage(IWebDriver webDriver, SeleniumHelper seleniumHelper)
        {
            _webDriver = webDriver;
            _seleniumHelper = seleniumHelper;
        }

        public bool IsDisplayed()
        {
            return _webDriver.FindElement(By.XPath("//h1[contains(.,'Hola')]")).Displayed;
        }

        public bool IsUserSIgnedIn(Usuario user)
        {
            return _webDriver.FindElement(By.XPath("//a[contains(.,'Logout')]")).Displayed
                   && _seleniumHelper.IsContentonPage("Hola " + user.firstName);
        }
    }
}
