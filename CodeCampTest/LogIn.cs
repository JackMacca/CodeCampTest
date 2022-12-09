﻿using OpenQA.Selenium;

namespace CodeCampTest
{
    internal class LogIn
    {
        private IWebDriver driver;

        public LogIn(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickLogIn()
        {
            driver.FindElement(By.ClassName("btnPrimary")).Click();
        }

        internal void ClickProfile()
        {
            driver.FindElement(By.CssSelector("[aria-label='your profile']")).Click();
        }

        internal void SetPassword(string password)
        {
            var passwordList = driver.FindElements(By.ClassName("v-input"));
            passwordList[1].FindElement(By.Id("gen-20221209-password")).SendKeys(password);
        }

        internal void SetUsername(string username)
        {
            var usernameList = driver.FindElements(By.ClassName("v-input"));
            usernameList[0].FindElement(By.Id("gen-20221209-username")).SendKeys(username);
        }

        internal string VerifyHeader(string expectedText)
        {
            var headerText = driver.FindElement(By.ClassName("v-main"));
            // tried to get text from h2 and wanted to see if it equaled to Welcome bob but couldn't quite grab the text correctly
            if (headerText.FindElement(By.ClassName("container")).Text.ToLower() == expectedText.ToLower())
            {
                return driver.Url;
            }

            throw new ArgumentException("Couldn't find " + expectedText);
        }
    }
}