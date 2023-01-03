using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class Tests
    {

        [Test]
        public void ValidateTitleTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";


            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }



   

            //driver.Url = "https://google";

           
            

        
    }
}
//https://opensource-demo.orangehrmlive.com/