using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages.DemoPages
{
    public class TableDataSearchPage : PageBase
    {
        private IWebDriver _driver;
        private TableDataSearchBlock _tableDataSearchBlock;

        public TableDataSearchPage(IWebDriver driver, TableDataSearchBlock tableDataSearchBlock) : base(driver)
        {
            this._driver = driver;
            this._tableDataSearchBlock = tableDataSearchBlock;
        }

        public void EnterTextIntoTasksInputField(string text) =>
            _tableDataSearchBlock.EnterTextIntoTasksInputField(text);

        public List<SearchResultTask> ReturnSearchResults() =>
            _tableDataSearchBlock.ExtractVisibleResultsFromSearchTable();
    }
}