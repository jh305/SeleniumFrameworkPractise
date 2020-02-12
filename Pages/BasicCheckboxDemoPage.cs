using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages
{
    public class BasicCheckboxDemoPage : PageBase
    {
        IWebDriver Driver;

        public BasicCheckboxDemoPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetClickOnThisCheckBoxElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#isAgeSelected")));

        private IWebElement GetCheckAllButtonElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#check1")));

        public void ClickCheckAllButton() =>
            GetCheckAllButtonElement().Click();
    }
}