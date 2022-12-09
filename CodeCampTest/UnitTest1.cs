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
            driver.Url = "https://d3nay7txmslpgb.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void openPage_LogOn_VerifyHeader()
        {
            new Toolbar(driver).ClickLogIn();

            var login = new LogIn(driver);
            login.SetUsername("bob");
            login.SetPassword("ilovepizza");
            login.ClickLogIn();
            login.ClickProfile();
            // look in login.VerifyHeader for more info
            var headerText = login.VerifyHeader("Welcome bob");
            login.ClickProfile();

        }

        [TestMethod]
        public void openMenu_clickSides_findKoreanStickyWings()
        {
            new Toolbar(driver).ClickMenu();

            var sidesMenu = new SideMenu(driver);

            sidesMenu.ClickSides();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}