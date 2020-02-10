using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Pages
{
    public class HomePage : PageBase
    {
        private IWebDriver Driver;

        public BasicExamples BasicExamplesBlock;
        public IntermediateExamples IntermediateExamplesBlock;
        public AdvancedExamples AdvancedxamplesBlock;

        public HomePage(IWebDriver driver, BasicExamples basicExamplesBlock, IntermediateExamples intermediateExamplesBlock, AdvancedExamples advancedExamplesBlock) : base(driver)
        {
            this.Driver = driver;
            this.BasicExamplesBlock = basicExamplesBlock;
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
            this.AdvancedxamplesBlock = advancedExamplesBlock;
        }

        private IWebElement GetStartPractisingButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_basic_example")));

        public void ClickStartPractisingElement ()
        {
            ScrollElementIntoView(GetStartPractisingButtonElement());
            GetStartPractisingButtonElement().Click();
        }

        public void NavigateToPage() =>
            Driver.Url = "https://www.seleniumeasy.com/test/";
    }
}