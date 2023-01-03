using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeMethod() {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";


        }

        [TearDown]
        public void AfterMethod()
        {

            driver.Quit();
        }
        
        [Test]
        public void ValidateTitleTest() { 
        

        

            //driver.Url = "https://google";

            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }

          [Test]
          public void ValidatePlaceholderTest()
        {

           
            //driver.FindElement(By.Name("Username")).Clear();

            string actualUsernamePlaceholder=driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));

            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));




        }




   

         

           
            

        
    }
}
//https://opensource-demo.orangehrmlive.com/