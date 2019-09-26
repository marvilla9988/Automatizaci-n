using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using OpenQA.Selenium;

namespace Pages.Pages
{
    public class RegisterPage
    {
        private IWebDriver _webDriver;

        private By _fName = By.Id("inputFirstName");
        private  By _lName = By.Id("inputLastName");
        private By _uName = By.Id("inputUsername");
        private By _iPassword = By.Id("inputPassword");
        private By _btnRegistrarse = By.Id("buttonRegistrarse");

        public RegisterPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void RegistrarUsuario(Usuario user)
        {

            // ingresar informacion del usuario
            _webDriver.FindElement(_fName).SendKeys(user.firstName);
            _webDriver.FindElement(_lName).SendKeys(user.lastName);
            _webDriver.FindElement(_uName).SendKeys(user.username);
            _webDriver.FindElement(_iPassword).SendKeys(user.password);

            //click
            _webDriver.FindElement(_btnRegistrarse).Click();
        }

    }
}
