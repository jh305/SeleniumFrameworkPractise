using SeleniumFrameworkPractise.Blocks;

namespace SeleniumFrameworkPractise.Steps
{
    public class AdvancedExamplesSteps
    {
        private AdvancedExamples AdvancedExamples;

        public AdvancedExamplesSteps(AdvancedExamples advancedExamples)
        {
            this.AdvancedExamples = advancedExamples;
        }

        public void ClickDragAndDropLink() =>
            AdvancedExamples.ClickDragAndDropLinkElement();
    }
}