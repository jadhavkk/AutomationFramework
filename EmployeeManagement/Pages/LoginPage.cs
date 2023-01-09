using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Presentation;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
     public class LoginPage
    {

        private By _usernameLocator = By.Name("username");
        private By _passwordLocator = By.Name("password");
        private By _loginPageLocator = By.XPath("//button[@type='submit']");

        private By _forgotPassword = By.XPath("//p[contains(normalize-space(),'Forgot')]");
        private By _GetInvalidErrorMessage = By.XPath("//p[contains(normalize-space(),'cred')]");



        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public  void EnterUsername(string username) {


            driver.FindElement(_usernameLocator).SendKeys(username);
           // driver.FindElement(By.Name("username")).SendKeys(username);
           
        }
        public  void EnterPassword(string password)
        {

            driver.FindElement(_passwordLocator).SendKeys(password);
            // driver.FindElement(By.Name("password")).SendKeys(password);
        }
    
        public void ClickOnLogin()
        {

            driver.FindElement(_loginPageLocator).Click();
            //driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void ClickOnForgotPassword() {

            driver.FindElement(_forgotPassword).Click();
            //driver.FindElement(By.XPath("//p[contains(normalize-space(),'Forgot')]")).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(_GetInvalidErrorMessage).Text;
            //return driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
        }
    }
}
