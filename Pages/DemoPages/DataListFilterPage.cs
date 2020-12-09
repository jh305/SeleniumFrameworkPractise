using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages
{
    public class DataListFilterPage : PageBase
    {
        private IWebDriver _driver;

        DataListFilterBlock _dataListFilterBlock;

        public DataListFilterPage(IWebDriver driver, DataListFilterBlock dataListFilterBlock) : base(driver)
        {
            this._driver = driver;
            this._dataListFilterBlock = dataListFilterBlock;
        }

        private IWebElement GetSearchAttendeesInputElement() =>
            WaitAndReturnElement("#input-search");

        public void EnterAttendeeNameIntoFilter(string text) =>
            ClearAndSendKeys(GetSearchAttendeesInputElement(), text);

        public List<SearchResultAttendee> getResults() =>
            _dataListFilterBlock.ExtractVisibleResultsFromSearchTable();
    }
}