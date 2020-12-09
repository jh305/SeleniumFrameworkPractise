using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class IntermediateExamplesSteps
    {
        private IntermediateExamplesBlock _intermediateExamplesBlock;

        public IntermediateExamplesSteps(IntermediateExamplesBlock intermediateExamplesBlock)
        {
            this._intermediateExamplesBlock = intermediateExamplesBlock;
        }

        public void ClickProceedNextButton() =>
            _intermediateExamplesBlock.ClickProceedNextButton();

        public void ClickDataListFilterLink() =>
            _intermediateExamplesBlock.ClickDataListFilterLink();

        public void ClickJQuerySelectDropDownLink() =>
            _intermediateExamplesBlock.ClickJQuerySelectDropDownLink();
    }
}