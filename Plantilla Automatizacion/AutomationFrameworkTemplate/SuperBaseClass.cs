using OpenQA.Selenium;
using Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace AutomationFrameworkTemplate
{

    public class SuperBaseClass
    {
        public LoginPage _loginPage;
        public RegisterPage _registerPage;
        public HomePage _homePage;

        private IWebDriver _driver;
        private DataHelper _dataHelper;
        private SeleniumHelper _seleniumHelper;

        public HomePage HomePage
        {
            get
            {
                if (_homePage == null)
                    _homePage = new HomePage(WebDriver, SeleniumHelper);
                return _homePage;
            }
            set => _homePage = new HomePage(WebDriver, SeleniumHelper);
        }

        public LoginPage LoginPage
        {
            get
            {
                if (_loginPage == null)
                    _loginPage = new LoginPage(WebDriver, SeleniumHelper);
                return _loginPage;
            }
            set => _loginPage = new LoginPage(WebDriver, SeleniumHelper);
        }

        public RegisterPage RegisterPage
        {
            get
            {
                if (_registerPage == null)
                    _registerPage = new RegisterPage(WebDriver);
                return _registerPage;
            }
            set => _registerPage = new RegisterPage(WebDriver);
        }

        public IWebDriver WebDriver
        {
            get
            {
                return _driver;
            }

            set => _driver = value;
        }

        public SeleniumHelper SeleniumHelper {
            get {
                if (_seleniumHelper == null)
                    _seleniumHelper = new SeleniumHelper(WebDriver);
                return _seleniumHelper;
            }
        }

        public DataHelper DataHelper
        {
            get
            {
                if (_dataHelper == null)
                    _dataHelper = new DataHelper();
                return _dataHelper;
            }
        }
    }

}
