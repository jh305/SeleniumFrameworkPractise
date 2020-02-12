using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.Settings;

namespace SeleniumFrameworkPractise.Pages
{
    public class HomePage : PageBase
    {
        private IWebDriver Driver;

        public BasicExamplesBlock BasicExamplesBlock;
        public IntermediateExamplesBlock IntermediateExamplesBlock;
        public AdvancedExamplesBlock AdvancedxamplesBlock;

        public HomePage(IWebDriver driver, BasicExamplesBlock basicExamplesBlock, IntermediateExamplesBlock intermediateExamplesBlock, AdvancedExamplesBlock advancedExamplesBlock) : base(driver)
        {
            this.Driver = driver;
            this.BasicExamplesBlock = basicExamplesBlock;
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
            this.AdvancedxamplesBlock = advancedExamplesBlock;
        }

        public HomePage(IWebDriver driver, BasicExamplesBlock basicExamplesBlock) : base(driver)
        {
            this.Driver = driver;
            this.BasicExamplesBlock = basicExamplesBlock;
        }

        public HomePage(IWebDriver driver, BasicExamplesBlock basicExamplesBlock, IntermediateExamplesBlock intermediateExamplesBlock) : base(driver)
        {
            this.Driver = driver;
            this.BasicExamplesBlock = basicExamplesBlock;
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
        }

        private IWebElement GetStartPractisingButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_basic_example")));

        public void ClickStartPractisingElement()
        {
            ScrollElementIntoView(GetStartPractisingButtonElement());
            GetStartPractisingButtonElement().Click();
        }

        public void NavigateToPage() =>
            Driver.Url = TestSettings.TestUrl;
    }
}