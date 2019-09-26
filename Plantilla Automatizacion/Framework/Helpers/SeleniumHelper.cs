using System;
using OpenQA.Selenium;
using System.Threading;

namespace Utilities.Helpers
{
    public class SeleniumHelper
    {

        IWebDriver _driver;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;       
        }

        public bool IsContentonPage(string content) {
            Thread.Sleep(2000);
            return _driver.PageSource.Contains(content);
        }

        public void executeJavaScriptToHideElement()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("$('.btn-link').remove()");
        }

        public void UploadFile(string filepath)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("hhacer visbile elemento");
            //string filename = SeleniumHelper.GetFilePath();
            //Elemento.SendKeys(filename);
            
        }

        public string getAlertText()
        {
           /* IAlert alert = _driver.SwitchTo(IAlert);
            string alertText = alert.Text;
            alert.accept();
            return alertText;*/

            return "";
        }
    }
}
