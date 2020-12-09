using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class AdvancedExamplesBlock: BlockBase
    {
        private IWebDriver _driver;

        public AdvancedExamplesBlock(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private IWebElement GetTableDataSearchLinkElement() =>
            WaitAndReturnElement("#advanced > div > a:nth-child(2)");

        public void ClickTableDataSearchElement()
        {
            try
            {
                _wait.Until(condition =>
                    WaitForElementToBeVisible(GetTableDataSearchLinkElement()));

                GetTableDataSearchLinkElement().Click();
            }
            catch (ElementClickInterceptedException)
            {
                ClosePopupWindow();
                GetTableDataSearchLinkElement().Click();
            }
        }
    }
}