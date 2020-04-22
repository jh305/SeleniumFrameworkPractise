using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class DataListFilterSteps
    {
        private DataListFilterPage DataListFilterPage;

        public DataListFilterSteps(DataListFilterPage dataListFilterPage)
        {
            this.DataListFilterPage = dataListFilterPage;
        }

        public void SearchForAttendee(string attendeeName) =>
            DataListFilterPage.EnterAttendeeNameIntoFilter(attendeeName);

        public List<SearchResultAttendee> getResults() =>
            DataListFilterPage.getResults();
    }
}