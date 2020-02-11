using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class DataListFilterSteps
    {
        DataListFilterPage DataListFilterPage;

        public DataListFilterSteps(DataListFilterPage dataListFilterPage)
        {
            this.DataListFilterPage = dataListFilterPage;
        }

        public SearchResultAttendee asdfsdafsafd() =>
            DataListFilterPage.ReturnResultOfSearchObject();

        public void SearchForAttendee(string attendeeName) =>
            DataListFilterPage.EnterAttendeeNameIntoFilter(attendeeName);
    }
}