using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class AdvancedExamplesSteps
    {
        private AdvancedExamplesBlock _advancedExamplesBlock;

        public AdvancedExamplesSteps(AdvancedExamplesBlock advancedExamplesBlock)
        {
            this._advancedExamplesBlock = advancedExamplesBlock;
        }

        public void ClickTableDataSearchLink() =>
            _advancedExamplesBlock.ClickTableDataSearchElement();
    }
}