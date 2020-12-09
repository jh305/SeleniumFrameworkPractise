using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkPractise.Pages.Popups;
using SeleniumFrameworkPractise.Shared;
using System;

namespace SeleniumFrameworkPractise
{
    public class PageBase : SharedToolsBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        private Actions Actions;

        private LearnSeleniumPopup LearnSeleniumPopup;

        public PageBase(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
            this.Actions = GetActions();
            this.LearnSeleniumPopup = new LearnSeleniumPopup(Driver);
        }

        public Actions GetActions() =>
            new Actions(Driver);

        public void ScrollElementIntoView(IWebElement Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", Element);
        }

        public bool WaitForElementToBeVisible(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private IWebElement GetSlider1CurrentRangeElement() =>
            Driver.FindElement(By.CssSelector("#slider1 > div.range > output#range"));

        public void ClosePopupWindow()
        {
            if (LearnSeleniumPopup.IsPopupVisible() == true)
            {
                LearnSeleniumPopup.ClosePopupWindow();
            }
        }
    }
}