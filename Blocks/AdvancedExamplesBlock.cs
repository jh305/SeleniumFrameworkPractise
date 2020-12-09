using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class AdvancedExamplesBlock: BlockBase
    {
        private IWebDriver Driver;

        public AdvancedExamplesBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetTableDataSearchLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(2)")));

        public void ClickTableDataSearchElement()
        {
            try
            {
                Wait.Until(condition =>
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