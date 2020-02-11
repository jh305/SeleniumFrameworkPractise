using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class IntermediateExamplesSteps
    {
        IntermediateExamplesBlock IntermediateExamplesBlock;

        public IntermediateExamplesSteps(IntermediateExamplesBlock intermediateExamplesBlock)
        {
            this.IntermediateExamplesBlock = intermediateExamplesBlock;
        }

        public void ClickProceedNextButton() =>
            IntermediateExamplesBlock.ClickStartPractisingButton();

        public void ClickDataListFilterLink() =>
            IntermediateExamplesBlock.ClickDataListFilterLink();
    }
}