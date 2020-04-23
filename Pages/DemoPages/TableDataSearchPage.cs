using OpenQA.Selenium;

namespace SeleniumFrameworkPractise.Pages.DemoPages
{
    public class TableDataSearchPage : PageBase
    {
        private IWebDriver Driver;

        public TableDataSearchPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }

        private IWebElement GetTasksInputFieldElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#task-table-filter")));

        public void EnterTextIntoTasksInputField(string text) =>
            ClearAndSendKeys(GetTasksInputFieldElement(), text);
    }
}