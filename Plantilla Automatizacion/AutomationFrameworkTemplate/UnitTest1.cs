using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using OpenQA.Selenium;
using Utilities.Helpers;

namespace AutomationFrameworkTemplate
{
    [TestClass]
    public class UnitTest1 : TestBaseClass
    {


      
        [TestMethod]
        public void UnSuccesfulLogin()
        {
            var testUser = new Usuario("marquito", "juanito", "", "");

            LoginPage.LoginUser(testUser);

            Assert.IsTrue(LoginPage.WasLoginSuccessful());
        }

        [TestMethod]
        public void SuccessfulLogin()
        {
            
            var testUser = new Usuario("username", "password", "pablo", "calvo");
            //var testUser = DataHelper.NewUser();

            LoginPage.ClickRegistrarse();
            RegisterPage.RegistrarUsuario(testUser);
            Thread.Sleep(2000);
            LoginPage.LoginUser(testUser);

            Assert.IsTrue(HomePage.IsDisplayed());
            Assert.IsTrue(HomePage.IsUserSIgnedIn(testUser));
        }

        [TestMethod]
        public void JavaScriptTest()
        {

            SeleniumHelper.executeJavaScriptToHideElement();

            LoginPage.ClickRegistrarse();
      
        }

    }
}
