using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class AdvancedExamplesBlock: BlockBase
    {
        IWebDriver Driver;

        public AdvancedExamplesBlock(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetTableDataSearchLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(2)")));

        public void ClickTableDataSearchElement()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetTableDataSearchLinkElement()));

            GetTableDataSearchLinkElement().Click();
        }
    }
}