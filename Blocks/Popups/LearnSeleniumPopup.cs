using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages.Popups
{
    public class LearnSeleniumPopup : PopupBase
    {
        private IWebDriver _driver;

        public LearnSeleniumPopup(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private IWebElement GetClosePopupWebElement() =>
            WaitAndReturnElement("#at-cv-lightbox-close");

        public void ClosePopupWindow()
        {
            GetClosePopupWebElement().Click();
            WaitAndReturnElement("#at-cv-lightbox");
        }

        public bool IsPopupVisible() =>
            GetClosePopupWebElement().Displayed;
    }
}