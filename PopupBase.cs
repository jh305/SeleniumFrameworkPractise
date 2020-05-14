using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFrameworkPractise
{
    public class PopupBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        public PopupBase(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = GetWait();
        }

        public WebDriverWait GetWait()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }
    }
}