using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class IntermediateExamplesBlock : BlockBase
    {
        IWebDriver Driver;

        public IntermediateExamplesBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetProceedNextButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#btn_advanced_example")));

        private IWebElement GetDataListFilterLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#intermediate > div > a:nth-child(6)")));

        private IWebElement GetJQuerySelectDropDownLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#intermediate > div > a:nth-child(3)")));

        public void ClickProceedNextButton()
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

        public void ClickDataListFilterLink()
        {
            try
            {
                Wait.Until(condition =>
                    WaitForElementToBeVisible(GetDataListFilterLinkElement()));

                ScrollElementIntoView(GetDataListFilterLinkElement());
                GetDataListFilterLinkElement().Click();
            }
            catch (ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetDataListFilterLinkElement().Click();
            }            
        }

        public void ClickJQuerySelectDropDownLink()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetJQuerySelectDropDownLinkElement()));

            ScrollElementIntoView(GetJQuerySelectDropDownLinkElement());
            GetJQuerySelectDropDownLinkElement().Click();
        }
    }
}