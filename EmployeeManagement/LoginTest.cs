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


           // string actualUrl = driver.Url;
            //Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));



        }

        public static object[] InvalidLoginData()

        {

            string[] dataSet1 = new string[2];
            dataSet1[0] = "peter";
            dataSet1[1] = "peter677";
            dataSet1[2] = "Invalid credential";

            string[] dataSet2 = new string[2];
            dataSet2[0] = "jack";
            dataSet2[1] = "jack565";
            dataSet2[2] = "Invalid credential";

            string[] dataSet3 = new string[2];
            dataSet3[0] = "paul";
            dataSet3[1] = "paul587";
            dataSet3[2] = "Invalid credential";


            object[] allDataSet = new object[3]; //number of testcase
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;






        }


        [Test,TestCaseSource(nameof(InvalidLoginData))]
       //[TestCase("john","john234","Invalid credential")]
       // [TestCase("jack","jack345","Invalid credential")]
        //[TestCase("peter","peter55","Invalid credential")]
        public void InvalidLoginTest(string username,string password,string expectedError )
        {
            driver.FindElement(By.Name("username")).SendKeys("username");
            driver.FindElement(By.Name("password")).SendKeys("password");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            //(By.PartialLinkText("Invalid credentials"))
            Console.WriteLine(actualError.ToUpper());
           // Assert.That(actualError.Contains("Invalid Credential"));
            Assert.That(actualError.Contains(expectedError),"Assertion on error message");

            //Assert.That(true);
        } } }

