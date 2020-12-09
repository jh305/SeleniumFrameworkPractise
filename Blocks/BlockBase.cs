using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkPractise.Pages.Popups;
using SeleniumFrameworkPractise.Shared;
using System;

namespace SeleniumFrameworkPractise
{
    public class BlockBase : SharedToolsBase
    {
        private IWebDriver _driver;

        private LearnSeleniumPopup _learnSeleniumPopup;

        public BlockBase(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
            this._learnSeleniumPopup = new LearnSeleniumPopup(_driver);
        }

        public void ScrollElementIntoView(IWebElement Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
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

        public void ClosePopupWindow()
        {
            if (_learnSeleniumPopup.IsPopupVisible() == true)
            {
                _learnSeleniumPopup.ClosePopupWindow();
            }            
        }
    }
}