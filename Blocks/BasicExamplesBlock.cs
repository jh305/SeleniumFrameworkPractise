using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class BasicExamplesBlock : BlockBase
    {
        private IWebDriver _driver;

        public BasicExamplesBlock(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        private IWebElement GetProceedNextButtonElement() =>
            WaitAndReturnElement("#btn_inter_example");

        private IWebElement GetSimpleFormDemoLinkElement() =>
            WaitAndReturnElement("#basic > div > a:nth-child(1)");

        private IWebElement GetCheckboxDemoLinkElement() =>
            WaitAndReturnElement("#basic > div > a:nth-child(2)");

        public void ClickProceedNextElement()
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

        public void ClickSimpleFormDemoLink()
        {
            try
            {
                _wait.Until(condition =>
                WaitForElementToBeVisible(GetSimpleFormDemoLinkElement()));

                GetSimpleFormDemoLinkElement().Click();
            }
            catch(ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetSimpleFormDemoLinkElement().Click();
            }
            
        }

        public void ClickCheckboxDemoLink()
        {
            _wait.Until(condition =>
                WaitForElementToBeVisible(GetCheckboxDemoLinkElement()));

            GetCheckboxDemoLinkElement().Click();
        }
    }
}