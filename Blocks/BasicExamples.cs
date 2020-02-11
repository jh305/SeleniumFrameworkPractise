using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class BasicExamples : BlockBase
    {
        IWebDriver Driver;
        public BasicExamples(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }
        IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_inter_example")));

        IWebElement GetSimpleFormDemoLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#basic > div > a:nth-child(1)")));

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
    }
}