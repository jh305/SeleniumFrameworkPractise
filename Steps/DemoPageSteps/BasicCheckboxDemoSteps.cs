using SeleniumFrameworkPractise.Pages;

namespace SeleniumFrameworkPractise.Steps.DemoPageSteps
{
    public class BasicCheckboxSteps
    {
        private BasicCheckboxPage BasicCheckboxDemoPage;
        public BasicCheckboxSteps(BasicCheckboxPage basicCheckboxDemoPage)
        {
            this.BasicCheckboxDemoPage = basicCheckboxDemoPage;
        }

        public bool SingleCheckboxTest()
        {
            if (BasicCheckboxDemoPage.SelectSingleCheckbox() && BasicCheckboxDemoPage.CheckboxIsCheckedSuccessMessageStatus())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MultipleCheckboxTest()
        {
            BasicCheckboxDemoPage.ClickCheckAllButton();

            if (BasicCheckboxDemoPage.CheckAllOptionCheckboxesAreChecked())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}