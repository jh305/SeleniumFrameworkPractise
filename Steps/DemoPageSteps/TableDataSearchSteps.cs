using SeleniumFrameworkPractise.PageObjects;
using SeleniumFrameworkPractise.Pages.DemoPages;
using System.Collections.Generic;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class TableDataSearchSteps
    {
        private TableDataSearchPage _tableDataSearchPage;

        public TableDataSearchSteps(TableDataSearchPage tableDataSearchPage)
        {
            this._tableDataSearchPage = tableDataSearchPage;
        }

        public void SearchForTaskAssigneeStatus(string taskOrAssigneeOrStatus) =>
            _tableDataSearchPage.EnterTextIntoTasksInputField(taskOrAssigneeOrStatus);

        public List<SearchResultTask> GetDataSearchResults() =>
            _tableDataSearchPage.ReturnSearchResults();
    }
}