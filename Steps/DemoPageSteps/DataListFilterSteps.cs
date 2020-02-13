﻿using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class DataListFilterSteps
    {
        private DataListFilterPage DataListFilterPage;

        public DataListFilterSteps(DataListFilterPage dataListFilterPage)
        {
            this.DataListFilterPage = dataListFilterPage;
        }

        public SearchResultAttendee ExtractAttendeeDataOfFirstSearchResult() =>
            DataListFilterPage.ReturnResultOfSearchObject();

        public void SearchForAttendee(string attendeeName) =>
            DataListFilterPage.EnterAttendeeNameIntoFilter(attendeeName);
    }
}