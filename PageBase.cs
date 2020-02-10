﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFrameworkPractise
{
    public class PageBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        public Actions Actions;

        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = GetWait();
            this.Actions = GetActions();
        }

        public WebDriverWait GetWait() =>
              new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

        public Actions GetActions() =>
            new Actions(Driver);

        public void ScrollElementIntoView(IWebElement Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", Element);
        }
    }
}