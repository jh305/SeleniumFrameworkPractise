using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages
{
    public class DataListFilterPage : PageBase
    {
        IWebDriver Driver;

        DataListFilterBlock DataListFilterBlock;

        public DataListFilterPage(IWebDriver driver, DataListFilterBlock dataListFilterBlock) : base(driver)
        {
            this.Driver = driver;
            this.DataListFilterBlock = dataListFilterBlock;
        }

        private IWebElement GetSearchAttendeesInputElement() =>
            Wait.Until(d => d.FindElement(By.CssSelector("#input-search")));

        public void EnterAttendeeNameIntoFilter(string text) =>
            ClearAndSendKeys(GetSearchAttendeesInputElement(), text);

        public List<SearchResultAttendee> getResults() =>
            DataListFilterBlock.ExtractVisibleResultsFromSearchTable();
    }
}