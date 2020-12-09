using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFrameworkPractise.Shared
{
    public class SharedToolsBase
    {
        IWebDriver _driver;

        protected WebDriverWait _wait;

        public SharedToolsBase(IWebDriver driver)
        {
            this._driver = driver;
            this._wait = GetWait();
        }

        public WebDriverWait GetWait() =>
              new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

        protected IWebElement WaitAndReturnElement(string cssSelector) =>
            _wait.Until(d => ReturnElement(cssSelector));

        protected IWebElement ReturnElement(string cssSelector) => _driver.FindElement(By.CssSelector(cssSelector));

        protected void ClearAndSendKeys(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}