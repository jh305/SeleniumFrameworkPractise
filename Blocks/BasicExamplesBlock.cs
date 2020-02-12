using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class BasicExamplesBlock : BlockBase
    {
        IWebDriver Driver;
        public BasicExamplesBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }
        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_inter_example")));

        IWebElement GetSimpleFormDemoLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#basic > div > a:nth-child(1)")));

        IWebElement GetCheckboxDemoLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#basic > div > a:nth-child(2)")));

        public void ClickProceedNextElement()
        {
            Wait.Until(condition => 
                WaitForElementToBeVisible(GetProceedNextButtonElement()));

            ScrollElementIntoView(GetProceedNextButtonElement());
            GetProceedNextButtonElement().Click();
        }

        public void ClickSimpleFormDemoLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetSimpleFormDemoLinkElement()));

            GetSimpleFormDemoLinkElement().Click();
        }

        public void ClickCheckboxDemoLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetCheckboxDemoLinkElement()));

            GetCheckboxDemoLinkElement().Click();
        }
    }
}