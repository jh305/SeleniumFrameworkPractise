using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class IntermediateExamplesBlock : BlockBase
    {
        private IWebDriver _driver;

        public IntermediateExamplesBlock(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        private IWebElement GetProceedNextButtonElement() =>
            WaitAndReturnElement("#btn_advanced_example");

        private IWebElement GetDataListFilterLinkElement() =>
            WaitAndReturnElement("#intermediate > div > a:nth-child(6)");

        private IWebElement GetJQuerySelectDropDownLinkElement() =>
            WaitAndReturnElement("#intermediate > div > a:nth-child(3)");

        public void ClickProceedNextButton()
        {
            try
            {
                _wait.Until(condition =>
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
                _wait.Until(condition =>
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
            _wait.Until(condition =>
                WaitForElementToBeVisible(GetJQuerySelectDropDownLinkElement()));

            ScrollElementIntoView(GetJQuerySelectDropDownLinkElement());
            GetJQuerySelectDropDownLinkElement().Click();
        }
    }
}