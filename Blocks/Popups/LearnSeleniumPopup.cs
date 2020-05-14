using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages.Popups
{
    public class LearnSeleniumPopup : PopupBase
    {
        private IWebDriver Driver;

        public LearnSeleniumPopup(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetClosePopupWebElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#at-cv-lightbox-close")));

        public void ClosePopupWindow()
        {
            GetClosePopupWebElement().Click();
            Wait.Until(d => d.FindElements(By.CssSelector("#at-cv-lightbox")).Count == 0);
        }

        public bool IsPopupVisible() =>
            GetClosePopupWebElement().Displayed;
    }
}