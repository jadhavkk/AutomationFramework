using EmployeeManagement.Base;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITests : AutomationWrapper
    {
       // protected IWebDriver driver;

        [Test]
        public void ValidateTitleTest()
        {
             //driver.Url = "https://google;
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }

        [Test]
        public void ValidatePlaceholderTest()
        {


            //driver.FindElement(By.Name("Username")).Clear();

            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));

            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));

















        }
    }
}
//https://opensource-demo.orangehrmlive.com/