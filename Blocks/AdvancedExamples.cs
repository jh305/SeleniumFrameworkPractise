using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Blocks
{
    public class AdvancedExamples: BlockBase
    {
        IWebDriver Driver;

        public AdvancedExamples(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        IWebElement GetDragAndDropLinkElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#advanced > div > a:nth-child(9)")));

        public void ClickDragAndDropLinkElement() =>
            GetDragAndDropLinkElement().Click();
    }
}