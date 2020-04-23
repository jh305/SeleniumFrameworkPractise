

using SeleniumFrameworkPractise.Pages.DemoPages;

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
    }
}