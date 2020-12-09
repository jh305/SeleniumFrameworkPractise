using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkPractise.Pages.Popups;
using System;

namespace SeleniumFrameworkPractise
{
    public class BlockBase
    {
        private IWebDriver Driver;

        public WebDriverWait Wait;

        private LearnSeleniumPopup LearnSeleniumPopup;

        public BlockBase(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = GetWait();
            this.LearnSeleniumPopup = new LearnSeleniumPopup(Driver);
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

        public void ClearAndSendKeys(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
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