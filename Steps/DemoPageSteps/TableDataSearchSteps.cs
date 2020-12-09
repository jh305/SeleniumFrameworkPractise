using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages.DemoPages;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class TableDataSearchSteps
    {
        private TableDataSearchPage TableDataSearchPage;

        public TableDataSearchSteps(TableDataSearchPage tableDataSearchPage)
        {
            this.TableDataSearchPage = tableDataSearchPage;
        }

        public void SearchForTaskAssigneeStatus(string taskOrAssigneeOrStatus) =>
            TableDataSearchPage.EnterTextIntoTasksInputField(taskOrAssigneeOrStatus);

        public List<SearchResultTask> GetDataSearchResults() =>
            TableDataSearchPage.ReturnSearchResults();
    }
}