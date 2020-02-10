﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFrameworkPractise
{
    public class BlockBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        public BlockBase(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = GetWait();
        }

        public WebDriverWait GetWait()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

        public void ScrollElementIntoView(IWebElement Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", Element);
        }

        public bool ElementIsDisplayed(IWebElement element)
        {
            try
            {
                if (element.Displayed)
                {
                    return true;
                }

                return false;

            }
            catch
            {
                return false;
            }
        }
    }
}