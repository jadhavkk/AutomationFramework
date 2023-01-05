using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        
        [Test ,TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        public void AddEmployeeTest(string username, string password,string firstname,string middlename,string lastname, string actualresult)
        {
           driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            // string actualUrl = driver.Url;
            // Assert.That(actualUrl.Contains.);

            //Console.WriteLine(actualresult);

            //driver.FindElement(By.XPath("//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[2]")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='PIM']")).Click();

            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();

           driver.FindElement(By.Name("firstName")).SendKeys(firstname);
              driver.FindElement(By.Name("middleName")).SendKeys(middlename);
            driver.FindElement(By.Name("lastName")).SendKeys(lastname);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualtext = driver.FindElement(By.CssSelector("[class='oxd-text oxd-text--h6 --strong']")).Text;
            actualtext.Contains(actualtext);
            // actualtext.CompareTo(actualtext);
            // // actualtext.ToCharArray();



            Assert.That(actualresult.Contains(actualtext), "Assertion is not work");

















            // actualtext.ToCharArray();




        }
    }
}
