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

        IWebElement GetDragAndDropSlidersLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(8)")));

        IWebElement GetDragAndDropLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(9)")));

        public void ClickDragAndDropSlidersLinkElement()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetDragAndDropSlidersLinkElement()));

            GetDragAndDropSlidersLinkElement().Click();
        }

        public void ClickDragAndDropLinkElement()
        {
            Wait.Until(condition =>
                WaitForElementToBeVisible(GetDragAndDropLinkElement()));

            GetDragAndDropLinkElement().Click();
        }            
    }
}