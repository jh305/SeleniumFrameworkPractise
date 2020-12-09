using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class DataListFilterSteps
    {
        private DataListFilterPage _dataListFilterPage;

        public DataListFilterSteps(DataListFilterPage dataListFilterPage)
        {
            this._dataListFilterPage = dataListFilterPage;
        }

        public void SearchForAttendee(string attendeeName) =>
            _dataListFilterPage.EnterAttendeeNameIntoFilter(attendeeName);

        public List<SearchResultAttendee> GetDataListSearchResults() =>
            _dataListFilterPage.getResults();
    }
}