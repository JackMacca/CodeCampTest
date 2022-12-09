using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeCampTest
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Initialisze()
        {
            driver = new ChromeDriver();
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}