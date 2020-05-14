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
        private IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_inter_example")));

        private IWebElement GetSimpleFormDemoLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#basic > div > a:nth-child(1)")));

        private IWebElement GetCheckboxDemoLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#basic > div > a:nth-child(2)")));

        public void ClickProceedNextElement()
        {
            try
            {
                Wait.Until(condition =>
                WaitForElementToBeVisible(GetProceedNextButtonElement()));

                ScrollElementIntoView(GetProceedNextButtonElement());
                GetProceedNextButtonElement().Click();
            }
            catch (ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetProceedNextButtonElement().Click();
            }            
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