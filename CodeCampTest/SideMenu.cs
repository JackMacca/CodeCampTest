using OpenQA.Selenium;

namespace CodeCampTest
{
    internal class SideMenu
    {
        private IWebDriver driver;

        public SideMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickSides()
        {
            var menuButtons = driver.FindElements(By.ClassName("v-tab"));
            menuButtons[0].Click();
        }
    }
}