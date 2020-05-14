using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.Settings;

namespace SeleniumFrameworkPractise.Pages
{
    public class Homepage : PageBase
    {
        private IWebDriver Driver;

        public BasicExamplesBlock BasicExamplesBlock;
        public IntermediateExamplesBlock IntermediateExamplesBlock;
        public AdvancedExamplesBlock AdvancedxamplesBlock;

        public Homepage(IWebDriver driver, BasicExamplesBlock basicExamplesBlock, IntermediateExamplesBlock intermediateExamplesBlock) : base(driver)
        {
            this.Driver = driver;
            this.BasicExamplesBlock = basicExamplesBlock;
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
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
            Driver.Url = TestSettings.SeleniumEasyUrl;
    }
}