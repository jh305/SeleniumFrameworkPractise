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

        IWebElement GetDragAndDropLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(9)")));

        public void ClickDragAndDropLinkElement()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetDragAndDropLinkElement()));

            GetDragAndDropLinkElement().Click();
        }            
    }
}