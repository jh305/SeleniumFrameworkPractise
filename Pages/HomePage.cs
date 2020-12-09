using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.Settings;

namespace SeleniumFrameworkPractise.Pages
{
    public class Homepage : PageBase
    {
        private IWebDriver _driver;

        public BasicExamplesBlock _basicExamplesBlock;
        public IntermediateExamplesBlock _intermediateExamplesBlock;
        public AdvancedExamplesBlock _advancedxamplesBlock;

        public Homepage(IWebDriver driver, BasicExamplesBlock basicExamplesBlock, IntermediateExamplesBlock intermediateExamplesBlock) : base(driver)
        {
            this._driver = driver;
            this._basicExamplesBlock = basicExamplesBlock;
            this._intermediateExamplesBlock = intermediateExamplesBlock;
        }

        private IWebElement GetStartPractisingButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_basic_example")));

        public void ClickStartPractisingElement()
        {
            try
            {
                ScrollElementIntoView(GetStartPractisingButtonElement());
                GetStartPractisingButtonElement().Click();
            }
            catch (ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetStartPractisingButtonElement().Click();
            }
            
        }
        public void NavigateToPage() =>
            _driver.Url = TestSettings.SeleniumEasyUrl;
    }
}