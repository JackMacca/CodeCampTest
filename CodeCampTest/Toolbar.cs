using OpenQA.Selenium;

namespace CodeCampTest
{
    internal class Toolbar
    {
        private IWebDriver driver;

        public Toolbar(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickLogIn()
        {
            driver.FindElement(By.CssSelector("[aria-label='login or signup'].v-btn")).Click();
        }

        internal void ClickMenu()
        {
            driver.FindElement(By.CssSelector("[aria-label=menu].v-btn")).Click();
        }
    }
}