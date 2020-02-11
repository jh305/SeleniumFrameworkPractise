using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class IntermediateExamplesSteps
    {
        IntermediateExamples IntermediateExamples;

        public IntermediateExamplesSteps(IntermediateExamples intermediateExamples)
        {
            this.IntermediateExamples = intermediateExamples;
        }

        public void ClickProceedNextButton() =>
            IntermediateExamples.ClickStartPractisingButton();

        public void ClickDataListFilterLink() =>
            IntermediateExamples.ClickDataListFilterLink();
    }
}