﻿using OpenQA.Selenium;
using SeleniumFrameworkPractise.Blocks;
using SeleniumFrameworkPractise.PageObjects;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Pages
{
    public class DataListFilterPage : PageBase
    {
        private IWebDriver Driver;

        DataListFilterBlock DataListFilterBlock;

        public DataListFilterPage(IWebDriver driver, DataListFilterBlock dataListFilterBlock) : base(driver)
        {
            this.Driver = driver;
            this.DataListFilterBlock = dataListFilterBlock;
        }

        private IWebElement GetSearchAttendeesInputElement() =>
            WaitAndReturnElement("#input-search");

        public void EnterAttendeeNameIntoFilter(string text) =>
            ClearAndSendKeys(GetSearchAttendeesInputElement(), text);

        public List<SearchResultAttendee> getResults() =>
            DataListFilterBlock.ExtractVisibleResultsFromSearchTable();
    }
}