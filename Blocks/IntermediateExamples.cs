using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class IntermediateExamples : BlockBase
    {
        IWebDriver Driver;

        public IntermediateExamples(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_advanced_example")));

        IWebElement GetDataListFilterLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#intermediate > div > a:nth-child(6)")));

        public void ClickStartPractisingButton()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetProceedNextButtonElement()));

            ScrollElementIntoView(GetProceedNextButtonElement());
            GetProceedNextButtonElement().Click();
        }

        public void ClickDataListFilterLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetDataListFilterLinkElement()));

            ScrollElementIntoView(GetDataListFilterLinkElement());
            GetDataListFilterLinkElement().Click();
        }
    }
}