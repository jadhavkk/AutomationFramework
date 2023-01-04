using EmployeeManagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            //(//button[normalize-space=' Login '])


            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));



        }


        [Test]
        [TestCase("john","john234","Invalid credential")]
        [TestCase("jack","jack345","Invalid credential")]
        [TestCase("peter","peter55","Invalid credential")]
        public void InvalidLoginTest(string username,string password,string expectedError )
        {
            driver.FindElement(By.Name("username")).SendKeys("username");
            driver.FindElement(By.Name("password")).SendKeys("password");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            //(By.PartialLinkText("Invalid credentials"))
            Console.WriteLine(actualError.ToUpper());
           // Assert.That(actualError.Contains("Invalid Credential"));
            Assert.That(actualError.Contains("expectedError"),"Assertion on error message");

            //Assert.That(true);
        } } }

