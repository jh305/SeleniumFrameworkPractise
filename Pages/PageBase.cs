using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkPractise.Pages.Popups;
using System;

namespace SeleniumFrameworkPractise
{
    public class PageBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        private Actions Actions;

        private LearnSeleniumPopup LearnSeleniumPopup;

        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = GetWait();
            this.Actions = GetActions();
            this.LearnSeleniumPopup = new LearnSeleniumPopup(Driver);
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

        public void ClearAndSendKeys(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
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

        public void ClosePopupWindow()
        {
            if (LearnSeleniumPopup.IsPopupVisible() == true)
            {
                LearnSeleniumPopup.ClosePopupWindow();
            }
        }
    }
}