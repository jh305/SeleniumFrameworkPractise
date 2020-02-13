using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class IntermediateExamplesSteps
    {
        private IntermediateExamplesBlock IntermediateExamplesBlock;

        public IntermediateExamplesSteps(IntermediateExamplesBlock intermediateExamplesBlock)
        {
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
        }

        public void ClickProceedNextButton() =>
            IntermediateExamplesBlock.ClickProceedNextButton();

        public void ClickDataListFilterLink() =>
            IntermediateExamplesBlock.ClickDataListFilterLink();

        public void ClickJQuerySelectDropDownLink() =>
            IntermediateExamplesBlock.ClickJQuerySelectDropDownLink();
    }
}