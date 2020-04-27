using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages.DemoPages
{
    public class TableDataSearchPage : PageBase
    {
        private IWebDriver Driver;
        private TableDataSearchBlock TableDataSearchBlock;

        public TableDataSearchPage(IWebDriver driver, TableDataSearchBlock tableDataSearchBlock) : base(driver)
        {
            this.Driver = driver;
            this.TableDataSearchBlock = tableDataSearchBlock;
        }

        public void EnterTextIntoTasksInputField(string text) =>
            TableDataSearchBlock.EnterTextIntoTasksInputField(text);

        public List<SearchResultTask> ReturnSearchResults() =>
            TableDataSearchBlock.ExtractVisibleResultsFromSearchTable();
    }
}